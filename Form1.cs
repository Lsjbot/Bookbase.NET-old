using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ReadCrossref;
using System.Text.RegularExpressions;


namespace Bookbase
{
    public partial class Form1 : Form
    {
        private Button xx = new System.Windows.Forms.Button();

        public Librarydb db = null;
        public static string connectionstring = "Data Source=KOMPLETT2015;Initial Catalog=\"librarydb\";Integrated Security=True";

        public Form1()
        {
            //xx.Location = new Point(100, 100);
            //xx.Text = "Test button";
            //xx.Size = new System.Drawing.Size(75, 23);
            ////xx.TabIndex = 0;
            //xx.UseVisualStyleBackColor = true;
            ////xx.Click += new System.EventHandler(xx_Click);
            //this.Controls.Add(xx);
            InitializeComponent();
            db = new Librarydb(connectionstring);
        }

        private void LookButton_Click(object sender, EventArgs e)
        {
            FormLook fl = new FormLook(db);
            fl.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            FormFindAuthor fa = new FormFindAuthor(db);

            DialogResult faresult = fa.ShowDialog();
            var auid = fa.authorid;
            //memo("authorid = " + auid.ToString());

            if ((faresult == DialogResult.OK) && (auid >= 0))
            {
                FormNewBook fd = new FormNewBook(db, auid,null);
                fd.Show();
            }

        }

        private void BKBbutton_Click(object sender, EventArgs e)
        {
            //Generate BKB file, for backwards compatibility with my old Bookbase program


            string fn = @"d:\Bookbase\books-generated-"+DateTime.Now.ToShortDateString()+".bkb";
            Encoding eansi = Encoding.GetEncoding(1252);
            using (StreamWriter sw = new StreamWriter(new FileStream(fn, FileMode.Create, FileAccess.Write), eansi))
            {
                sw.WriteLine("0\tBOOKS");

                int n = 1;

                foreach (BookAlbum ba in (from c in db.BookAlbum where c.Type == 0 select c))
                {
                    StringBuilder sb = new StringBuilder(n.ToString() + "\t");
                    n++;
                    sb.Append(authorclass.BookAuthorString(db, ba) + "\t");
                    sb.Append(ba.Title + "\t");
                    if (ba.Publisher != null)
                        sb.Append(ba.PublisherPublisher.Name + "\t");
                    else
                        sb.Append("\t");
                    sb.Append(dbutil.bkbdate(ba.DateBought) + "\t");
                    sb.Append(dbutil.bkbyear(ba.YearFirst) + "\t");
                    sb.Append(dbutil.bkbyear(ba.YearThis) + "\t");
                    sb.Append(ba.WhereBought + "\t");
                    sb.Append(dbutil.bkbprice(ba.Price) + "\t");
                    sb.Append("1\t");
                    sb.Append(dbutil.bkbprice(ba.Liked) + "\t");
                    sb.Append(ba.Subject + "\t");
                    sb.Append("Sverker");
                    sw.WriteLine(sb.ToString());
                    foreach (ChapterSong cs in ba.ChapterSong)
                    {
                        StringBuilder sbb = new StringBuilder(n.ToString() + "\t#\t");
                        n++;
                        sbb.Append(authorclass.ChapterAuthorString(db, cs) + "\t");
                        sbb.Append(cs.Title);
                        sw.WriteLine(sbb.ToString());
                    }

                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            FormDelete fd = new FormDelete(db);
            fd.Show();
        }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            FormListmaker fa = new FormListmaker(db,RB_music.Checked);

            fa.Show();
        }

        private string getleaf(string path)
        {
            
            string s = path.Split('\\').Last();
            return s;
        }

        private string getsong(string path)
        {
            string[] ss = getleaf(path).Split('.');
            string s = ss[0];
            if (ss.Length > 1)
            {
                s = getleaf(path).Replace("." + ss.Last(),"");
            }
            string rex = @"(\d\d - )";
            foreach (Match match in Regex.Matches(s, rex, RegexOptions.IgnoreCase))
            {
                memo("Full match = " + match.Value);
                memo("Found (1) "+match.Groups[1].Value);
                s = s.Replace(match.Value, "");
            }


            return s;

        }

        private void artistfolder(string folder, string artistname)
        {
            memo("Artist name " + artistname);

            int auid = authorclass.NewAuthor(db, artistname);
            foreach (string subfolder in Directory.GetDirectories(folder))
            {
                memo("Album " + getleaf(subfolder));
                foreach (string file in Directory.GetFiles(subfolder))
                    memo("Song " + getsong(file));
            }

        }

        private void artistfolder(string folder)
        {
            artistfolder(folder, getleaf(folder));

        }

        private void extract_from_foldertree(string folder)
        {
            foreach (string subfolder in Directory.GetDirectories(folder))
            {
                memo("Before 00-if "+subfolder);
                if (getleaf(subfolder).StartsWith("00-"))
                {
                    memo("00-");
                    if (getleaf(subfolder).Contains("lassical"))
                        extract_from_foldertree(subfolder);
                    else
                        artistfolder(subfolder, "-");
                }
                else
                    artistfolder(subfolder);
            }
        }

        private void Directorybutton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowserDialog1.SelectedPath;
                memo(folder);
                extract_from_foldertree(folder);
            }
        }

        public void memo(string s)
        {
            richTextBox1.AppendText(s + "\n");
            richTextBox1.ScrollToCaret();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modifybutton_Click(object sender, EventArgs e)
        {
            FormModify fm = new FormModify(db);
            fm.Show();
        }
    }
}

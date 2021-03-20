namespace Bookbase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuitButton = new System.Windows.Forms.Button();
            this.LookButton = new System.Windows.Forms.Button();
            this.Bookbutton = new System.Windows.Forms.Button();
            this.BKBbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Listbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_music = new System.Windows.Forms.RadioButton();
            this.RB_literature = new System.Windows.Forms.RadioButton();
            this.Directorybutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Modifybutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(476, 328);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(146, 55);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // LookButton
            // 
            this.LookButton.Location = new System.Drawing.Point(12, 12);
            this.LookButton.Name = "LookButton";
            this.LookButton.Size = new System.Drawing.Size(153, 62);
            this.LookButton.TabIndex = 1;
            this.LookButton.Text = "Look at information";
            this.LookButton.UseVisualStyleBackColor = true;
            this.LookButton.Click += new System.EventHandler(this.LookButton_Click);
            // 
            // Bookbutton
            // 
            this.Bookbutton.Location = new System.Drawing.Point(12, 92);
            this.Bookbutton.Name = "Bookbutton";
            this.Bookbutton.Size = new System.Drawing.Size(153, 57);
            this.Bookbutton.TabIndex = 2;
            this.Bookbutton.Text = "Add new book or CD";
            this.Bookbutton.UseVisualStyleBackColor = true;
            this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click);
            // 
            // BKBbutton
            // 
            this.BKBbutton.Location = new System.Drawing.Point(504, 8);
            this.BKBbutton.Name = "BKBbutton";
            this.BKBbutton.Size = new System.Drawing.Size(118, 61);
            this.BKBbutton.TabIndex = 3;
            this.BKBbutton.Text = "Generate BKB file";
            this.BKBbutton.UseVisualStyleBackColor = true;
            this.BKBbutton.Click += new System.EventHandler(this.BKBbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(504, 170);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(117, 60);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete information";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(504, 92);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(118, 57);
            this.Listbutton.TabIndex = 5;
            this.Listbutton.Text = "Generate list";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_music);
            this.groupBox1.Controls.Add(this.RB_literature);
            this.groupBox1.Location = new System.Drawing.Point(186, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RB_music
            // 
            this.RB_music.AutoSize = true;
            this.RB_music.Location = new System.Drawing.Point(13, 49);
            this.RB_music.Name = "RB_music";
            this.RB_music.Size = new System.Drawing.Size(53, 17);
            this.RB_music.TabIndex = 1;
            this.RB_music.TabStop = true;
            this.RB_music.Text = "Music";
            this.RB_music.UseVisualStyleBackColor = true;
            // 
            // RB_literature
            // 
            this.RB_literature.AutoSize = true;
            this.RB_literature.Checked = true;
            this.RB_literature.Location = new System.Drawing.Point(13, 26);
            this.RB_literature.Name = "RB_literature";
            this.RB_literature.Size = new System.Drawing.Size(69, 17);
            this.RB_literature.TabIndex = 0;
            this.RB_literature.TabStop = true;
            this.RB_literature.Text = "Literature";
            this.RB_literature.UseVisualStyleBackColor = true;
            // 
            // Directorybutton
            // 
            this.Directorybutton.Location = new System.Drawing.Point(12, 170);
            this.Directorybutton.Name = "Directorybutton";
            this.Directorybutton.Size = new System.Drawing.Size(153, 60);
            this.Directorybutton.TabIndex = 7;
            this.Directorybutton.Text = "Add from directory";
            this.Directorybutton.UseVisualStyleBackColor = true;
            this.Directorybutton.Click += new System.EventHandler(this.Directorybutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(193, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 121);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Modifybutton
            // 
            this.Modifybutton.Location = new System.Drawing.Point(12, 248);
            this.Modifybutton.Name = "Modifybutton";
            this.Modifybutton.Size = new System.Drawing.Size(153, 64);
            this.Modifybutton.TabIndex = 9;
            this.Modifybutton.Text = "Modify information";
            this.Modifybutton.UseVisualStyleBackColor = true;
            this.Modifybutton.Click += new System.EventHandler(this.Modifybutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 395);
            this.Controls.Add(this.Modifybutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Directorybutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Listbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.BKBbutton);
            this.Controls.Add(this.Bookbutton);
            this.Controls.Add(this.LookButton);
            this.Controls.Add(this.QuitButton);
            this.Name = "Form1";
            this.Text = "Bookbase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button LookButton;
        private System.Windows.Forms.Button Bookbutton;
        private System.Windows.Forms.Button BKBbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_music;
        private System.Windows.Forms.RadioButton RB_literature;
        private System.Windows.Forms.Button Directorybutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Modifybutton;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bookbase
{
    class util
    {
        public static string addid(string s, int id, int pad)
        {
            return s.PadRight(pad) + "|" + id.ToString() + "|";
        }

        public static int getid(string s)
        {
            string rex = @"\|(\d+)\|";
            foreach (Match match in Regex.Matches(s, rex))
            {
                return tryconvert(match.Groups[1].Value);
            }

            return -1;

        }

        public static int tryconvert(string word)
        {
            int i = -1;

            try
            {
                i = Convert.ToInt32(word);
            }
            catch (OverflowException)
            {
                //memo("i Outside the range of the Int32 type: " + word);
            }
            catch (FormatException)
            {
                //if ( !String.IsNullOrEmpty(word))
                //    Console.WriteLine("i Not in a recognizable format: " + word);
            }

            return i;

        }

        public static string format_authorlist(List<string> ls)
        {
            
            if (ls.Count == 0)
                return "";
            else if (ls.Count == 1)
                return ls[0];
            else if ( ls.Count < 4)
            {
                string s = ls[0];
                for (int i = 1; i < ls.Count; i++)
                    s += " & " + ls[i];
                return s;
            }
            else
            {
                return ls[0] + " et al.";
            }
            
        }

        public static string addcentury(int? year)
        {
            if (year == null)
                return "(no year)";
            if (year <= (DateTime.Now.Year % 100))
                return "20" + year.ToString();
            else if (year < 100)
                return "19" + year.ToString();
            else
                return year.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrom
{
    class Program
    {
        public static string FindPalidrom(string s , int left, int right)
        {
            while(left >=0 && right <s.Length && s[left]== s[right])
            {
                left--;
                right++;
            }

            left++;
            right = right - left;
            return s.Substring(left, right);
        }
        public static string LongestPalindrom(string s)
        {
            string Longest = s.Substring(0, 1);
            for (int i = 0; i < s.Length; i++)
            {
                //
                string foundstring = FindPalidrom(s, i, i);

               if (foundstring.Length > Longest.Length)
                {
                    Longest = foundstring;
                }

                foundstring = FindPalidrom(s, i, i+1);
                if (foundstring.Length > Longest.Length)
                {
                    Longest = foundstring;
                }
            }
            return Longest;
        }




        static void Main(string[] args)
        {

            string s = LongestPalindrom("712353216");
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}

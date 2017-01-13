using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {

        public static int lengthOfLastWord(String s)
        {
            if (s == null || s.Length == 0)
                return 0;

            int result = 0;
            int len = s.Length;

           
            for (int i = len - 1; i >= 0; i--)
            {
                char c = s[i];
                if (c == ' ')
                {
                    break;
                   
                }
                else
                {
                    result++;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string text = "the last word length in the text";
            int length = lengthOfLastWord(text);
            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}

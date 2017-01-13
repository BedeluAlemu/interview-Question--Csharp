using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubstring
{
    class Program
    {

        public static String longestSubstring(String a, String b)
        {
            String output = "";
            if (a.Length == 0 || b.Length == 0) return output;

            int len = 0;
            int[,] cache = new int[a.Length,b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i]== b[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            cache[i,j] = 1;
                        }
                        else
                        {
                            cache[i,j] = cache[i - 1,j - 1] + 1;
                        }
                        if (cache[i,j] > len)
                        {
                            len = cache[i,j];
                            output = a.Substring(i - len + 1, i + 1);
                        }
                    }
                }
            }
            Console.WriteLine(len);
            return output;
        }
        static void Main(string[] args)
        {

            string s = longestSubstring("aba", "ababab");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

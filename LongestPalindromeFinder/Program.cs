using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromeFinder
{
    class Program
    {
        static public String intermediatePalindrome(String s, int left, int right)
        {
            if (left > right) return null;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {  
                left--;
                right++;
            }
            
            
       
                left++;

                right = right - left;

            return s.Substring(left, right);
        }
        public static String longestPalindromeString(String s)
        {
              if (s == null) return null;
              String longest = s.Substring(0, 1);


            for (int i = 0; i < s.Length - 1; i++)
            {
                //odd cases like 121
                String palindrome = intermediatePalindrome(s, i, i);


                if (palindrome.Length > longest.Length)
                {
                    longest = palindrome;
                }

                //even cases like 1221
                palindrome = intermediatePalindrome(s, i, i + 1);

                if (palindrome.Length > longest.Length)
                {
                    longest = palindrome;
                }
            }

            return longest;
        }







        static void Main(string[] args)
        {
          
            Console.WriteLine(longestPalindromeString("1234"));
            Console.WriteLine(longestPalindromeString("12321"));
            Console.WriteLine(longestPalindromeString("9912321456"));
            Console.WriteLine(longestPalindromeString("dfabbahi"));
            Console.WriteLine(longestPalindromeString("9912333321456"));
            Console.WriteLine(longestPalindromeString("12145445499"));
            Console.WriteLine(longestPalindromeString("1223213"));
            Console.WriteLine(longestPalindromeString("abb"));
            Console.ReadLine();
        }
    }
}

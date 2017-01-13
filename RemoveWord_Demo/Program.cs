using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWord_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Programming is super fun!!! super super super :D";
            string word = "super ";

            Console.WriteLine("Original text: " + text);
            Console.WriteLine();

            Console.WriteLine("After remove the word \"{0}\": {1}", word, RemoveWord(text, word));

            Console.ReadKey();
        }

        private static string RemoveWord(string text, string word)
        {
            string result = string.Empty;

            string possibleMatch = string.Empty;
            for (int i = 0, j = 0; i < text.Length; i++)
            {

                char a = text[i];
                char b = word[j];
                if (text[i] == word[j])
                {
                    if (j == word.Length - 1) // match!
                    {
                        possibleMatch = string.Empty; // discard word!
                        j = 0; // restart!
                    }
                    else
                    {
                        // don't discard! It could match just partially!
                        possibleMatch += text[i];
                        j++;
                    }
                }
                else // don't match!
                {
                    // save possibleMatch
                    result += possibleMatch;
                    possibleMatch = string.Empty;

                    if (j == 0) // There is no way that current char can match anything...
                    {
                        result += text[i];
                    }
                    else // if it was in the middle of a search...
                    {
                        // current char doesn't match a char in the middle of 'word'...
                        // but it could match the beginning of 'word'!
                        // so...let's re-test!
                        j = 0;
                        i--;
                    }
                }
            }

            return result;
        }
    }
}





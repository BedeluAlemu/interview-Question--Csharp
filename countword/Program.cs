using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countword
{
    class Program
    {
        public static int Countword( string text, string word)
        {
            int count = 0;

            for (int i = 0 , j =0; i < text.Length; i++)
            {
                if (text[i]==word[j])
                {
                    if (word.Length - 1 == j)
                    {
                        count++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    j = 0;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string text = "Dummy text is text that is used in the publishing industry or by web designers to occupy the space which will later be filled with 'real' content. This is required when, for example, the final text is not yet available. Dummy text is also known as 'fill text'. It is said that song composers of the past used dummy texts as lyrics when writing melodies in order to have a 'ready-made' text to sing with the melody. Dummy texts have been in use by typesetters since the 16th century.";
            string word = "text";

            Console.WriteLine("Original text: " + text);
            Console.WriteLine();
            Console.WriteLine("The word \"{0}\" appears {1} times", word, Countword(text, word));

            Console.ReadKey();
        }
    }
}

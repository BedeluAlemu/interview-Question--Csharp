using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToUpperAndLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "PrograMMing iS fUN!";

            Console.WriteLine("Original text is: \"{0}\"", text);

            Console.WriteLine("ToUpper: \"{0}\"", ToUpper(text));
            Console.WriteLine("ToLower: \"{0}\"", ToLower(text));

            Console.ReadKey();
        }

        static string ToUpper(string text)
        {
            char[] textCharArr = text.ToCharArray();

            for (int i = 0; i < textCharArr.Length; i++)
            {
                char current = textCharArr[i];
                if (current >= 'a' && current <= 'z')
                {
                    int distance = current - 'a';
                    textCharArr[i] = (char)('A' + distance);
                }
            }

            return new string(textCharArr);
        }

        static string ToLower(string text)
        {
            char[] textCharArr = text.ToCharArray();

            for (int i = 0; i < textCharArr.Length; i++)
            {
                char current = textCharArr[i];
                if (current >= 'A' && current <= 'Z')
                {
                    int distance = current - 'A';
                    textCharArr[i] = (char)('a' + distance);
                }
            }

            return new string(textCharArr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsApp
{
    class Program
    {
        /// <summary>
        /// http://www.go4expert.com/articles/c-sharp-string-manipulation-tutorial-t30015/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string name = "Expert";
            Console.WriteLine(name);
            string description = "1-C#\n2-Java\n3-C++";
            Console.WriteLine(description);
            string content = @"8fsf8s\nsdf9sf_’’asaa";
            Console.WriteLine(content);
            char[] arr = "Expert".ToCharArray();
            string array = new string(arr);
            Console.WriteLine(array);


            //1. String Searching

            string name5 = "I am a CSharp Expert";
            char c = name5[1];    // This will return ‘x’, because x is located at first index of Expert

            // 1.1 Contains
            Console.WriteLine(name5.Contains("CSharp"));

            name5 = "James is  a CSharp Expert";

            // 1.2 StartsWith
            Console.WriteLine(name5.StartsWith("James"));

            // 1.3 EndsWith
            Console.WriteLine(name.EndsWith("Expert"));

            name5 = "Expert";

            Console.WriteLine(name5.IndexOf("per"));


            // String Manipulation


            // 1.Substring

            string name6 = "Expert";
            string sub = name6.Substring(1, 3);
            Console.WriteLine(sub);
            Console.WriteLine("===========\n");

            name6 = "Expert";
            sub = name6.Substring(2);
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");


            // 2.Insert

            Console.WriteLine("Using Insert function ...");
            name6 = "Expert";
            sub = name6.Insert(2, "--");
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");

            // 3.Remove
            Console.WriteLine("Using Remove function ...");
            name6 = "Ex--pert";
            sub = name6.Remove(2, 2);
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");

            // 3.1 Replace
            string s = "Dot Net Perls is about Dot Net.";
            Console.WriteLine(s);

            string v = s.Replace("Net", "Basket");
            Console.WriteLine(v);






            // 4.PadLeft and PadRight // create white space 

            name6 = "Expert";
            sub = name6.PadRight(5, '*');
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");

            //  6.ToUpper and ToLower
            Console.WriteLine("Using Trim function ...");
            name6 = "   I am a CSharp expert   ";
            sub = name6.Trim();
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");


            //6. ToUpper and ToLower

            Console.WriteLine("Using ToUpper function ...");
            name6 = "Expert";
            sub = name6.ToUpper();
            Console.WriteLine(sub);

            Console.ReadLine();


            // Join and Split Strings

            // 1.Split
            string conten = "I am a CSharp Expert";
            string[] str = conten.Split();
            foreach (string word in str)
            {
                Console.Write(word + "|");
            }
            Console.WriteLine();
            conten = "I,am,a,CSharp,Expert";
            str = conten.Split(',');
            foreach (string word in str)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n==========\n");

            // 2.Join
            Console.WriteLine("Using Join functions");
            str = "I am a CSharp Expert".Split(' ');
            conten = string.Join(",", str);
            Console.WriteLine(conten);
            Console.WriteLine("==========\n");

            // 3.Concat and '+'
            Console.WriteLine("Using Concatenate functions");
            string name7 = string.Concat("I ", "am ", " a", " CSharp", " Expert");
            Console.WriteLine(name7);

            name7 = "I " + "am " + " a" + " CSharp" + " Expert";
            Console.WriteLine(name7);




            Console.Read();
        }
    }
}

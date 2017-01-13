using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        public static void printPermutations(char[] input, int start)
        {
            //Base case for recursion, if start index is the end;
            //no need to recurse further, just print the pattern
            if (start == input.Length - 1)
            {
                for (int i = 0; i < input.Length; i++)
                    Console.Write(input[i]);
                    Console.WriteLine("\n");

            }
            else
            {
                //fix the first character and generate per
                for (int i = start; i < input.Length; i++)
                {
                    //swap start element, with ith element
                    if (i != start) // swap only if start, and i are different
                    {
                        char t = input[start];
                        input[start] = input[i];
                        input[i] = t;
                    }

                    printPermutations(input, start + 1);
                    //swap back the elements
                    if (i != start)
                    {
                        char t = input[start];
                        input[start] = input[i];
                        input[i] = t;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter please");
            string input = Console.ReadLine();
            char[] line = input.ToCharArray();
            printPermutations(line, 0);



            Console.ReadLine();

        }
    }
}

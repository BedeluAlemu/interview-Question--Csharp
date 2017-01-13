using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSubsequence
{
    class Program
    {
        public static int increasingSubsequence(int[] seq)
        {
            int[] L = new int[seq.Length];

            L[0] = 1;


            for (int i = 1; i < L.Length; i++)
            {
                int maxn = 0;
                for (int j = 0; j < i; j++)
                {
                    if (seq[j] < seq[i] && L[j] > maxn)
                    {
                        maxn = L[j];
                    }
                }
                L[i] = maxn + 1;
            }



            int maxi = 0;
            for (int i = 0; i < L.Length; i++)
            {
                if (L[i] > maxi)
                {
                    maxi = L[i];
                }
            }
            return (maxi);
        }



        static void Main(string[] args)
        {
            int[] arr = { 3, 4, -1, 0, 6, 2, 3 };
            int max = increasingSubsequence(arr);


            Console.WriteLine(max);
            Console.ReadLine();

        }
}
}

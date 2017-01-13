using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_sorted_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 1, 3, 8, 9 };
            int[] B = { 2, 4, 5, 6, 7, 0, 0, 0, 0 }; // last four as place holders for the merge

            // start from the end of the larger array;
            int idx = 8;
            // we also need the indices of the largest elements in both arrays
            int idx_a = 3, idx_b = 4;

            while (idx_a >= 0)
            { // done when A has been traversed
                if (idx_b < 0 || A[idx_a] > B[idx_b])
                { // if elements of b are exhausted
                    B[idx] = A[idx_a];
                    idx_a--;
                }
                else
                {
                    B[idx] = B[idx_b];
                    idx_b--;
                }
                idx--;
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i]+" ");
            }
            Console.ReadLine();
        }
    }
}

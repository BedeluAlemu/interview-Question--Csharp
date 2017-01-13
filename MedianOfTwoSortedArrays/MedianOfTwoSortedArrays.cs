using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    class MedianOfTwoSortedArrays
    {
        private static  int ERROR_INVALID_INPUT = -1; // change value of this const as per your specific requirement

        public int max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }

        public int min(int a, int b)
        {
            if (a < b) return a;
            return b;
        }

        private double findMedian(int[] array, int startIndex, int endIndex)
        {
            int indexDiff = (endIndex - startIndex);
            if (indexDiff % 2 == 0) // we are looking at odd number of elements
            {
                return array[startIndex + (indexDiff / 2)];
            }
            else
            {
                return 1.0 * (array[startIndex + (indexDiff / 2)] + array[startIndex + (indexDiff / 2) + 1]) / 2;
            }
        }



        ////1. If length of both arrays is 1, take average and return the value.
        ////2. If length of both arrays is 2, then return following value  (max(array1[0], array2[0]) + min(array1[1], array2[1]) )/2
        ////3. If length is greater than 2, follow steps below
        ////      3.a Find median of array A and array B individually.Let them be M1 and M2
        ////      3.b If M1 == M2 return M1
        ////      3.c If M1<M2, follow step 1 onwards with array A[mid...N] and array  B[0, mid - 1] 
        ////      3.d If M2<M1, follow step 1 onwards with array B[mid...N] and array  A[0, mid - 1]



        // a: 1,2,5,11,15  // b: 3 4 13 17 18
        public double findMedianSortedArrays(int[] a, int[] b, int startIndexA, int endIndexA, int startIndexB, int endIndexB)
        {

            if ((endIndexA - startIndexA < 0) || ((endIndexB - startIndexB < 0)))
            {
               Console.WriteLine("Invalid Input.");
                return ERROR_INVALID_INPUT;
            }

            if ((endIndexA - startIndexA == 0) && ((endIndexB - startIndexB == 0)))
            {
                return (a[0] + b[0]) / 2;
            }

            if ((endIndexA - startIndexA == 1) && ((endIndexB - startIndexB == 1)))
            {
                return (1.0 * (max(a[startIndexA], b[startIndexB]) + min(a[endIndexA], b[endIndexB]))) / 2;
            }






            double m1 = findMedian(a, startIndexA, endIndexA);
            double m2 = findMedian(b, startIndexB, endIndexB);

            if (m2 == m1)
            {
                return m2;
            }

            // since m1 <= median <= m2 narrow down search by eliminating elements less than m1 and elements greater than m2  
            if (m1 < m2)
            {
                if ((endIndexA - startIndexA) % 2 == 0) // we are looking at odd number of elements
                {
                    startIndexA = startIndexA + (endIndexA - startIndexA) / 2;
                    endIndexB = startIndexB + (endIndexB - startIndexB) / 2;
                }
                else
                {
                    startIndexA = startIndexA + (endIndexA - startIndexA) / 2;
                    endIndexB = startIndexB + (endIndexB - startIndexB) / 2 + 1;
                }
            }

            // since m2 <= median <= m1 narrow down search by eliminating elements less than m2 and elements greater than m1
            else // m2 < m1
            {
                if ((endIndexB - startIndexB) % 2 == 0) // we are looking at odd number of elements
                {
                    startIndexB = startIndexB + (endIndexB - startIndexB) / 2;
                    endIndexA = startIndexA + (endIndexA - startIndexA) / 2;
                }
                else
                {
                    startIndexB = startIndexB + (endIndexB - startIndexB) / 2;
                    endIndexA = startIndexA + (endIndexA - startIndexA) / 2 + 1;
                }
            }
            return findMedianSortedArrays(a, b, startIndexA, endIndexA, startIndexB, endIndexB);
        }

        static void Main(string[] args)
        {

            MedianOfTwoSortedArrays solution = new MedianOfTwoSortedArrays();

           Console.WriteLine("Case 1: When arrays have odd number of elements in them.");
            int[] a = { 1, 2, 3, 4, 5,7 };
            int[] b = { 6, 7, 8, 9, 10,12,13 };

           Console.WriteLine("Median: " + solution.findMedianSortedArrays(a, b, 0, a.Length - 1, 0, b.Length - 1));

           Console.WriteLine("-----------------");

           Console.WriteLine("Case 2: When arrays have even number of elements in them.");
            int[] c = { 1, 2, 99, 100 };
            int[] d = { 4, 5, 101, 102,105,107 };

           Console.WriteLine("Median: " + solution.findMedianSortedArrays(c, d, 0, c.Length - 1, 0, d.Length - 1));
           Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {

        public static void PrintArray(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static int [] Merge_Sort(int [] B)
        {
            int[] result = new int[B.Length];
            if (B.Length <= 1)
            {
                return B;   
            }
            int midpoint = B.Length / 2;
            int[] left = new int[midpoint];
            int[] right;

            if (B.Length % 2 == 0)
            {
                right = new int[midpoint];
            }
            else
            {
                right = new int[midpoint+1];
            }

            for (int i = 0; i < midpoint; i++)
            {
                left[i] = B[i];
                right[i] = B[i];

            }
            int j = 0;
            for (int i = midpoint; i < B.Length; i++)
            {
                
                right[j] = B[i];
                j++;

            }

            left = Merge_Sort(left);
            right = Merge_Sort(right);

            result = Merge(left, right);

            return result; 
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int i, j, k, array_siz ;
            i = 0; j = 0; k = 0;
            array_siz = left.Length + right.Length;
            int [] result = new int [array_siz] ;

            
            while (i < left.Length && j < right.Length)
            {  
                if (left[i] < right[j] )
                {
                      result[k]= left[i];
                    i++;
                }
                else
	            {
                     result[k]= right[j];
                      j++;
	            }
              
                k++; 
            }
            while (i < left.Length)
	        {
                result[k]= left[i];
                i++;
                k++;
	         
	            }
            while (j < right.Length)
	        {
	          result[k]= right[j];
                j++;
                k++;
	         }
            return result;
        }
        public static int [] Populate (int [] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
			{
                arr[i] = r.Next(0, 10);
			}
             
            
            return arr;
         }
        static void Main(string[] args)
        {
            int[] A = { 10, 7, 2, 9, 6, 1, 3, 5, 8, 4 };
              
            A  = Merge_Sort(A);
            PrintArray(A);
            Console.Read();
        }
    }
}

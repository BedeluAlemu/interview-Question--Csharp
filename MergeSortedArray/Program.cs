using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    class Program
    {
        public static void merge(int [] a, int [] b , int length)
        {
            int indexA = length - 1;
            int indexB = b.Length - 1;
            int indexmerge = a.Length - 1;
            while (indexA >= 0 && indexB >= 0)
            {
                if (a[indexA]>= b[indexB])
                {
                    a[indexmerge] = a[indexA];
                    indexA--;
                }
                else if (a[indexA] < b[indexB])
                {
                    a[indexmerge] = b[indexB];
                    indexB--;
                }
                indexmerge--;
            }
            while (indexB>=0)
            {
                a[indexmerge] = b[indexB];
                indexB--;
                indexmerge--;
            }
            // print 
            foreach (var item in a)
            {
                Console.Write(item +" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 0, 0, 0 };
            int[] b= { 5, 6, 7 };
            merge(a, b, 4);
            Console.ReadLine();
        }
    }
}

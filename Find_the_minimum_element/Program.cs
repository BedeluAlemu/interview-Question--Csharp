using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_minimum_element
{
    class Program
    {
        public static int findMin(int[] a, int left, int right)
        {

            //one element
            if (left == right)
            {
                return a[left];
            }

            //two elements
            if (left == right - 1)
            {
                return a[left] < a[right] ? a[left] : a[right];
            }

            //the array is ordered
            if (a[left] < a[right])
            {
                return a[left];
            }

            int mid = (left + right) / 2;

            if (a[mid] >= a[left])
            {
                return findMin(a, mid, right);
            }
            else
            {
                return findMin(a, left, mid);
            }

        }
        static void Main(string[] args)
        {
            int[]  arr1 = { 5, 6, 1, 2, 3, 4 };
             
            int num = findMin(arr1, 0, arr1.Length - 1);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}

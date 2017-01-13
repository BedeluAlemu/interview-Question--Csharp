using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    class Program
    {
        public static void  ThreeSum(int[]arr , int sum3)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int needed;

          

            for (int i = 0; i < arr.Length; i++)
            {
                needed = sum3- arr[i];
                result = FindTwo( arr, needed, i);
                foreach (var item in result)
                {
                    Console.WriteLine("{0},{1},{2}", i, item.Value, item.Key);
                }

             
            }

         
        }

        public static Dictionary<int, int> FindTwo(int[] arr, int sum2 , int x)
        {
            Dictionary<int, int> Store = new Dictionary<int, int>();
            Dictionary<int, int> result = new Dictionary<int, int>();
            int needed;

            for (int i = 0; i < arr.Length; i++)
            {

                   if (i!=x)
                    Store[arr[i]] = i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != x)
                {
                    needed = sum2 - arr[i];
                     
                       if (Store.ContainsKey(needed))
                       {
                            if (i > Store[needed])
                            {
                                result[i] = Store[needed];


                            }
                        
                    }
                }

              
            }

            return result;
        }

        static void Main(string[] args)
        {

            int[] arr = { -1 ,0 ,1 ,2 ,- 1 ,- 4 };
            int sum = 0;
             ThreeSum(arr, sum);


         
            Console.ReadLine();
        }
    }
}

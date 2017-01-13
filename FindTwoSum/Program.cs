using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 3, 5, 7, 9 };
            int [] numb = { 1, 3, 5, 7, 9 };
            int sum = 10;

        //    Tuple<int, int> indices = FindTwoSum(num, sum);
            Dictionary<int, int> x = Find(numb, sum);


          
            foreach (var item in x)
            {
                Console.WriteLine("value = {0} - index = {1}", item.Value, item.Key);
            }

            Console.ReadLine();
        }


        public static Dictionary<int, int> Find(int [] arr, int sum)
        {
            int needed;
            Dictionary<int, int> indexOfValue = new Dictionary<int, int>();
            Dictionary<int, int> SumIndex = new Dictionary<int, int>();

            for (int i = 0; i <arr.Length; i++)
            {
                indexOfValue[arr[i]] = i;
            }




            for (int i = 0; i < arr.Length; i++)
            {
                needed = sum - arr[i];
             
                if (indexOfValue.ContainsKey(needed))
                {
                     if (i > indexOfValue[needed])
                    SumIndex[i] = indexOfValue[needed];
                }
               
            }

            return SumIndex;
        }

        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            Dictionary<int, int> indexOfValue = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                indexOfValue[list[i]] = i;
            }

            for (int i = 0; i < list.Count; i++)
            {
                int value = list[i];
                int needed = sum - value;
                if (indexOfValue.ContainsKey(needed))
                {
                    return new Tuple<int, int>(i, indexOfValue[needed]);
                }
            }

            return null;
        }
    }
}

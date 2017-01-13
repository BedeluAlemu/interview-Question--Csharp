using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCoins
{
    class Program
    {
        // Recursive Solution to find minimum number of coins
        public static int getMinCoins(int[] values, int sum)
    {
        if (sum == 0)
            return 0;
        int min = int.MaxValue;
        for (int i = 0; i < values.Length; i++)
        {
            if (sum >= values[i])
                min = Math.Min(min, getMinCoins(values, sum - values[i]));
        }
        return min + 1;
    }

        


        // DP Solution to find minimum number of coins
        public static int getMinCoinsDP(int[] values, int sum)
    {
        int min = 0;
        int[] minCoins = new int[sum + 1];
        int x = 0;
        minCoins[0] = 0;

        for (int i = 1; i <= sum; i++)
        {
            min = int.MaxValue;
            for (int j = 0; j < values.Length; j++)
            {
                if (i >= values[j])
                 {
                        x = i - values[j];
                        min = Math.Min(min, minCoins[x]);
                    }
                    
            }

            if (min != int.MaxValue)
                minCoins[i] = min + 1;
            else
                minCoins[i] = int.MaxValue;
        }
        return minCoins[sum];
    }
 
   
  
        static void Main(string[] args)
        {

            int[] values = { 2, 5, 3 };
            int sum = 7;
            Console.WriteLine ("Minimum number of coins: " + getMinCoinsDP(values, sum));
            Console.ReadLine();
        }
    }
}

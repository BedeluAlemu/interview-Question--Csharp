using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangingMinimumCoin
{
     

        public class CoinChangingMinimumCoin
        {

            /**
             * Top down dynamic programing. Using map to store intermediate results.
             * Returns Integer.MAX_VALUE if total cannot be formed with given coins
             */
            public int minimumCoinTopDown(int total, int[] coins, Dictionary<int, int> map)
            {

                //if total is 0 then there is nothing to do. return 0.
                  if (total == 0)
                  {
                          return 0;
                   }

                      //if map contains the result means we calculated it before. Lets return that value.
                  if (map.ContainsKey(total))
                  {
                     return map[total];
                   }

                //iterate through all coins and see which one gives best result.
                int min = int.MaxValue;
                for (int i = 0; i < coins.Length; i++)
                {
                    //if value of coin is greater than total we are looking for just continue.
                    if (coins[i] > total)
                    {
                        continue;
                    }
                    //recurse with total - coins[i] as new total
                    int val = minimumCoinTopDown(total - coins[i], coins, map);

                    //if val we get from picking coins[i] as first coin for current total is less
                    // than value found so far make it minimum.
                    if (val < min)
                    {
                        min = val;
                    }
                }

                //if min is MAX_VAL dont change it. Just result it as is. Otherwise add 1 to it.

                min = (min == int.MaxValue ? min : min + 1);

                //memoize the minimum for current total.

                map.Add(total, min);

                return min;
            }

        /**
         * Bottom up way of solving this problem.
         * Keep input sorted. Otherwise temp[j-arr[i]) + 1 can become Integer.Max_value + 1 which
         * can be very low negative number
         * Returns Integer.MAX_VALUE - 1 if solution is not possible.
         */
        public int minimumCoinBottomUp(int total, int[] coins)
        {
            int[] T = new int[total + 1];
            int[] R = new int[total + 1];
            T[0] = 0;

            for (int i = 1; i <= total; i++)
            {
                T[i] = int.MaxValue - 1;
                R[i] = -1;
            }

            for (int j = 0; j < coins.Length; j++)
            {
                for (int i = 1; i <= total; i++)
                {
                    if (i >= coins[j])
                    {
                        if (T[i - coins[j]] + 1 < T[i])
                        {
                            T[i] = 1 + T[i - coins[j]];
                            R[i] = j;
                        }
                    }
                }
            }

            printCoinCombination(R, coins);

            return T[total];
        }

        private void printCoinCombination(int[] R , int[] coins )
            {
                if (R[R.Length - 1] == -1)
                {
                Console.WriteLine("No solution is possible");
                    return;
                }
                int start = R.Length - 1;
               Console.WriteLine ("Coins used to form total ");
                while (start != 0)
                {
                    int j = R[start];
                  Console.WriteLine (coins[j] + " ");
                    start = start - coins[j];
                }
                 Console.WriteLine  ("\n");
            }

             static void Main( )
            {
                int total = 5;
                int[] coins = { 1,2,3 };
                CoinChangingMinimumCoin cc = new CoinChangingMinimumCoin();
                Dictionary<int, int> map = new Dictionary<int, int>();
                int topDownValue = cc.minimumCoinTopDown(total, coins, map);
                int bottomUpValue = cc.minimumCoinBottomUp(total, coins);

                 Console.WriteLine ("Bottom up = {0} and top down =  {1}  ", topDownValue, bottomUpValue);
                Console.ReadLine();
            }
       }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseiinterger
{
    class Program
    {

        public static int ReverseInteger( int num)
        {
            int result = 0, rem = 0;

            while (num !=0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            return result;
        }
        static void Main(string[] args)
        {

          int num = Convert.ToInt32( Console.ReadLine());

           if (num < 0)
            {
                

                num = -1 * num;

                int rerNum = ReverseInteger(num);
                rerNum = -1 * rerNum;

                Console.WriteLine(rerNum);
            }
            else
            {
                
                int rerNum = ReverseInteger(num);
                Console.WriteLine(rerNum);
            }


            

            Console.ReadLine();
        }
    }
}

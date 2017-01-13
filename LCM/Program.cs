using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        public static int GCD(int a, int b)
        {
            int gcd = 0;
            
            if (a == 0 || b == 0)
            {
                gcd = 0;
                 
            }
            else 
            {
                if (a > b)
                {
                    for (int i = b; i > 0; i--)
                    {
                        if(a%i ==0 && b % i == 0)
                        {
                             gcd = i;
                            break;
                           
                        }
                    }
                }
                else if(b>a)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            gcd = i;
                            break;
                        }
                    }
                }
                else
                {
                    gcd = a;
                    

                }
            }
       
          
                return gcd;
           
             
        }

        public static int LCM(int a, int b)
        {
            int lcm = 0;
            bool found = false;
            int mult = 0;

            if (a == 0 || b == 0)
            {
                lcm = 0;

            }
            else
            {
                if (a > b)
                {
                    if (a % b == 0)
                    {
                        lcm = a;
                    }

                    else
                    {
                        int i = 2;
                        while(found != true)
                        {
                            mult = a * i;
      
                            if(mult % b == 0)
                            {
                                lcm = mult;
                                found = true;
                            }
                            i++;
                        }
                    }
                }
                else if (b>a)
                {
                    if (b % a == 0)
                    {
                        lcm = b;
                    }
                    else
                    {
                        int i = 2;
                        while (found != true)
                        {
                            mult = b * i;

                            if (mult % a == 0)
                            {
                                lcm = mult;
                                found = true;
                            }
                            i++;
                        }
                    }
                }

            }
            return lcm;
        }
        static void Main(string[] args)
        {
             int first = GCD(24,8);
            Console.WriteLine(first);


            int second = LCM(3, 2);
            Console.WriteLine(second);
 

            Console.ReadLine();
        }
    }
}

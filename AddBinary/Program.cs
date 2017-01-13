using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        public static String addBinary(String a, String b)
        {
            StringBuilder sb = new StringBuilder();

            int i = a.Length - 1;
            int j = b.Length - 1;

            int carry = 0;

            while (i >= 0 || j >= 0)
            {
                int sum = 0;

                if (i >= 0 && a[i] == '1')
                {
                    sum++;
                }

                if (j >= 0 && b[j] == '1')
                {
                    sum++;
                }

                sum += carry;

                if (sum >= 2)
                {

                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sb.Insert(0, (char)((sum % 2)+'0'));

                i--;
                j--;
            }

            if (carry == 1)
                sb.Insert(0, '1');

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string num = addBinary("1111111", "11111111");
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}

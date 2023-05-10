using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _31_ArmstrongNumWithinRange
    {
        public static void Main(string[] args)
        {
            int temp, n, r, sum;

            int a, b;
            Console.WriteLine("enter the range of the mumbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            for (n = a; n <= b; n++)
            {

                temp = n;
                sum = 0;
                while (temp > 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == n)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

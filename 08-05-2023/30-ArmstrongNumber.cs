using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _30_ArmstrongNumber
    {
        public static void Main(string[] args)
        {
            int temp, n, r, sum = 0;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an armstrong number");
            }
        }
    }
}

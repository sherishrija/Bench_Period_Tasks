using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _29_PerfectNumber
    {
        public static void Main()
        {
            //Sum of Factors = given number
            int n,sum=0;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum==n)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
            Console.ReadLine();
        }
    }
}

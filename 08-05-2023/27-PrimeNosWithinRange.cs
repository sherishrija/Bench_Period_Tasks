using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _27_PrimeNosWithinRange
    {
        public static void Main()
        {
            int m;
            Console.WriteLine("Enter the First Number");
            m = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("Enter the Second Number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers:");

            int count;
            int i, j;
          
            for (i = m; i <= n; i++)
            {
                count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                    
                    Console.WriteLine(i);
            }

        }
    }
}



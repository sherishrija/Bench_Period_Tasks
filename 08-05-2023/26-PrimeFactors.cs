using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _26_PrimeFactors
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the Number");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors:");
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }

            Console.ReadLine();
        }
    }
}

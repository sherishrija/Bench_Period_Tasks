using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class AscendingOrder_Numbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string num1 = num.ToString();
            char[] digits = num1.ToCharArray();
            Array.Sort(digits);
            Console.WriteLine("Ascending order of the given number is");
            foreach (char d in digits)
            {
                Console.WriteLine(d);
            }
        }
    }
}

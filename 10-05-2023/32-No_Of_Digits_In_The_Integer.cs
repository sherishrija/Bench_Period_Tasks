using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _32_No_Of_Digits_In_The_Integer
    {
        public static void Main()
        {
            int count = 0;
            Console.WriteLine("enter the number");
            double num = Convert.ToDouble(Console.ReadLine());
            string num1 = num.ToString();
            char[] digits = num1.ToCharArray();
            Console.WriteLine("The number of digits in the given number");
            for (int i = 0; i < digits.Length; i++)
            {

                Console.WriteLine(digits[i]);
                count++;
            }
            Console.WriteLine("The total number of digits in given number is  " + count);
        }
    }
}

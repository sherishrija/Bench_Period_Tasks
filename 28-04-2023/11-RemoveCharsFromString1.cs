using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class RemoveCharsFromString1
    {
        public static void Main()
        {
            // string str1 = "hello world";
            //string str2 = "aeiou";
            string str1, str2;
            Console.WriteLine("enter the strings:");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            string result = "";

            foreach (char c in str1)
            {
                if (!str2.Contains(c))
                {
                    result += c;
                }
            }

            Console.WriteLine(result);
        }
    }
}

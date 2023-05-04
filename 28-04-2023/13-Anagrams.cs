using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class Anagrams
    {
        public static void Main()
        {
            // string str1 = "silent";
            //string str2 = "listen";
            string str1, str2;
            Console.WriteLine("enter the strings:");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class vowels_consonants
    {
        public static void Main()
        {
            //string str = "Hello World";
            string str;
            Console.WriteLine("enter the string:");
            str = Console.ReadLine();
            int vowelCount = 0;
            int consonantCount = 0;

            foreach (char c in str.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.WriteLine("Number of consonants: " + consonantCount);
        }
    }
}


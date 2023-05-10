using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _37_RemovingSpacesIn_String
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("After removing spaces");
            string str1 = str.Replace(" ", "");
            Console.WriteLine(str1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class equalDiff
    {
        public static void Main()
        {
            Console.WriteLine("Enter any two names");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            if (name1.Equals(name2))
            {
                Console.WriteLine("Both names are equal");
            }
            else
                Console.WriteLine("Both are not equal");
            if (name1 == name2)
            {
                Console.WriteLine("Both names are equal");
            }
            else
                Console.WriteLine("Both are not equal");
        }
    }
}


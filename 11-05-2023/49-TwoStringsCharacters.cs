using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _49_TwoStringsCharacters
    {
        public static void Main()
        {


            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter first string");
            string str2 = Console.ReadLine();
            char[] str3 = str2.ToCharArray();
            for(int i=0;i<str2.Length; i++)
            {
                if( str1[0] == str3[i])
                    Console.WriteLine("given string starts with the contents of another string");
                
            }


        }
    }
}

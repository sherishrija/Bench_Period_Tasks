using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _39_CapitalizeFirst_LastCharOfEachWordInThe_String
    {
        static void Main()
        {
                Console.WriteLine("Enter any string:");
                string str= Console.ReadLine();
                char[] c = str.ToCharArray();
                 c[0]=  char.ToUpper(c[0]);
                 c[c.Length-1]= char.ToUpper(c[c.Length-1]); 
                Console.WriteLine(c);
            
        }
    }
}

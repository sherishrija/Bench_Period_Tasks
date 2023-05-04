using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _21_NonRepeatedDigits
    {
        public static void Main()
        {
            int[] array = new int[5];
            int j, k;
            Console.WriteLine("Enter the digits");
            for(int i =0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (j = 0; j < array.Length; j++)
            {
                for( k = 0; k<array.Length;k++)
                {
                    if (array[j] == array[k] && (j != k))
                        break;
                }
                if (k == array.Length)
                    Console.WriteLine("Non Repested Digits are" + array[j]);

            }
        }
    }
}

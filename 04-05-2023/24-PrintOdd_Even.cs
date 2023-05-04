using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _24_PrintOdd_Even
    {
        public static void Main()
        {
     
                //int even, odd, count = 0;
                Console.WriteLine("Enter the array size");

                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                    Console.WriteLine("list of odd numbers");
                    Console.WriteLine(array[i] + "");

                    }
                    else
                    {
                        Console.WriteLine("list of even numbers");
                        Console.WriteLine(array[i] + "");
                    }
                }

            }
        }
}

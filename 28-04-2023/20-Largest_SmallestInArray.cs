using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _20_Largest_SmallestInArray
    {
        static void Main()
        {
            int[] array = new int[5];
            int largest,smallest;
            Console.WriteLine("Enter the array elements");
            for(int i=0; i<5;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            largest = array.Max();
            smallest = array.Min();
            Console.WriteLine("Largest number is:" + largest);
            Console.WriteLine("Smallest number is:" + smallest);
        }
    }
}

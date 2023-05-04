using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _22_SecondLargestInArray
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int seclar;
            Console.WriteLine("Enter the array elements");
            for(int i =0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(array);
            Console.WriteLine("The Second Largest Number in the Array is:" + array[n - 2]);
        }
    }
}

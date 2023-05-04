using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _25_MergeTwoArrays
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the array1 size");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array2 size");

            int m = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[m];
            Console.WriteLine("the array1 elements are:");

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the array2 elements are:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] array3 = new int[array1.Length + array2.Length];
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
                count++;
            }
            for (int j = 0; j < array2.Length; j++)
            {
                array3[count++] = array2[j];
            }
            Console.WriteLine("Merge of two arrays :");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i] + "");
            }
        }
    }
}

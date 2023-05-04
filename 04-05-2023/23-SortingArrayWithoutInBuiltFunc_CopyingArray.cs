using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _23_SortingArrayWithoutInBuiltFunc_CopyingArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int[] num1 = new int[n];
            int i, j, k, temp;

            Console.WriteLine("Enter the elements:");
            for (k = 0; k < num.Length; k++)
            {
                num[k] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr1 = new int[num.Length];
            arr1 = num;

            Console.WriteLine("Copied elements of array1 to array2:");
            for (int l=0 ; l<arr1.Length ; l++)
            {
                Console.WriteLine(arr1[l]);
            }


            for (i = 1; i < num.Length; i++)
            {

                for (j = 0; j < num.Length - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array in ascending order is");
            foreach (var v in num)
            {
                temp = v;
                Console.WriteLine(v);
            }

        }
    }
}

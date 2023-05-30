using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _45_Shuffling_array
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements into an array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Shuffled array is:");
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }
}






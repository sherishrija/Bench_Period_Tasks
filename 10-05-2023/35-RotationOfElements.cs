﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _35_RotationOfElements
    {
        public static void Main()
        {
            Console.WriteLine("Enter the length of an array");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            Console.WriteLine("The array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            _35_RotationOfElements array = new _35_RotationOfElements();
            Console.WriteLine("The rotation of given array");
            array.LeftRotation(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        private void LeftRotation(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
        }
    }

}

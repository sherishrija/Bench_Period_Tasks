﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _36_StringLengthWithoutFunc
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int str1 = str.Length;
            int len = 0;
            for (int i = 1; i <= str1; i++)
            {
                len = i++;
            }
            Console.WriteLine("Length of the given string is " + len);
        }
    }
}

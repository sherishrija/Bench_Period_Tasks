﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _18_NoOfTimes_A
    {
        static void Main()
        {
            int count = 0;
            Console.WriteLine("Enter any string:");
            string string1 = Console.ReadLine();
            char[] c = string1.ToCharArray();
            for (int i = 0; i < string1.Length; i++)
            {
                if (c[i] == 'a')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No 'a' s are found");
            }
            else
            {
                Console.WriteLine($"Number of 'a's present was : {count}");
            }
        }

        
    }
}

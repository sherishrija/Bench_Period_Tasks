﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class Power
    {
        static void Main(string[] args)
        {
            int baseNumber, expNumber, result = 1;
            Console.Write("Base Number : ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("exponent Number : ");
            expNumber = Convert.ToInt32(Console.ReadLine());


            while (expNumber != 0)
            {
                result *= baseNumber;
                --expNumber;
            }

            Console.WriteLine("Result = {0}r", result);

            Console.ReadLine();
        }
    }
}


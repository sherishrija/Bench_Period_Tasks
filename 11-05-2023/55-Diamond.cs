using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    class _55_Diamond
    {
        public static void Main()
        {
            int Space, Number;
            Console.WriteLine("Pyramid of numbers");
            int numoflayer = 1, firstrows;
            Console.WriteLine("Enter the no.of layers:");
            firstrows = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=firstrows;i++)   //number of layers for pyramid
            {
                for (Space = 1; Space <= (firstrows - i); Space++) //loop for space
                {
                    Console.Write("");
                   
                }
                for(Number=1;Number<=i;Number++)  //increase the value
                {
                    Console.Write("*");
                }
                for (Number=(i-1);Number>=1;Number--)  //decrease the value
                {
                    Console.Write("*");
                }
                Console.WriteLine();


                for (int j=firstrows-1;j>=numoflayer;j--)
                {
                    for(Space=j;Space<=firstrows-numoflayer;Space++) //loop for space
                    {
                        Console.Write(" ");
                        
                    }
                    for (Number=1;Number<=j;Number++) //increase the value
                    {
                        Console.Write("*");

                    }
                    for(Number=(j-1);Number>=1;Number--) //decrease the value
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}



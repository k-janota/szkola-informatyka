using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goon = 1;
            int max = 0;

            int userInput = 0;
            bool isInt = true;

            while (goon == 1)
            {
                Console.WriteLine("enter a number");

                isInt = Int32.TryParse(Console.ReadLine(), out userInput);

                if (isInt)
                {
                    if (userInput > max)
                    {
                        max = userInput;
                    }



                }
                else
                {
                    goon = 2;
                }
            }
            Console.WriteLine("Maximum value: " + max);
            Console.ReadKey();
        }
    }
}

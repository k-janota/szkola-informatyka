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
            Random rnd = new Random();
            int txt1 = rnd.Next(1, 10);
            int a = 3;
            while (a > 0)
            {
                Console.WriteLine("strzelaj liczbe");
                string odp = Console.ReadLine();
                int odp2;
                int.TryParse(odp, out odp2);
                if (odp2 == txt1)
                {
                    Console.WriteLine("wygrałeś");
                }
                else
                {
                    Console.WriteLine("przegrałeś");
                }

                a--;
            }
            Console.WriteLine("liczba do zgadnięcia to było: " + txt1);
            Console.ReadKey();

        }
    }
}

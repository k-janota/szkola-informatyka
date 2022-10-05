using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("pierwszy bok: ");

            string a = Console.ReadLine();
            int bok1;
            int.TryParse(a, out bok1);



            Console.WriteLine("drugi bok: ");

            string a2 = Console.ReadLine();
            int bok2;
            int.TryParse(a2, out bok2);



            Console.WriteLine("trzeci bok: ");

            string a3 = Console.ReadLine();
            int bok3;
            int.TryParse(a3, out bok3);





            if (bok1 + bok2 > bok3 && bok2+bok3>bok1 && bok1+bok3>bok2) 
            {
                Console.WriteLine("da się zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("no że się nie da zbudować co nie");
            }
            Console.ReadKey();
        }
    }
}

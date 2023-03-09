using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Boss
    {

        public int moc;
        public int spryt;
        public int szybkosc;
        public Boss()
        {
            moc = 20;
            spryt = 25;
            szybkosc = 10;
        }

        public void RodzniaBossa()
        {
            Console.WriteLine("Zaopiekuj sie prosze moja corka powinna niedlugo wrocic do domu i przekaz jej ta kartke.");
        }
        public void StatyBoss()
        {
            Console.WriteLine($"Staty Bossa to {moc} mocy {spryt} sprytu {szybkosc} szybkosci");
        }

    }
}

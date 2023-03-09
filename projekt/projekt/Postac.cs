using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Postac
    {
        public string rodzaj;
        public int moc;
        public int spryt;
        public int szybkosc;

        public Postac()
        {
            rodzaj = "";
            moc = 0;
            spryt = 0;
            szybkosc = 0;
        }
        public class Wybor : Postac
        {
            public void ZestawyPostaci()
            {
                Console.WriteLine("Wybierz postać: 1 - Paladyn, 2 - Wojownik, 3 - Lucznik, 4 - Asasyn");
                int numer = int.Parse(Console.ReadLine());
                switch (numer)
                {
                    case 1:
                        rodzaj = "Paladyn";
                        moc = 10;
                        spryt = 10;
                        szybkosc = 10;
                        break;
                    case 2:
                        rodzaj = "Wojownik";
                        moc = 20;
                        spryt = 5;
                        szybkosc = 5;
                        break;
                    case 3:
                        rodzaj = "Lucznik";
                        moc = 6;
                        spryt = 14;
                        szybkosc = 10;
                        break;
                    case 4:
                        rodzaj = "Asasyn";
                        moc = 6;
                        spryt = 10;
                        szybkosc = 14;
                        break;
                    default:
                        Console.WriteLine("Sprawdz czy jest taki bohater!");
                        break;
                }
            }

            public void Upgrade(string upgrade)
            {
                switch (upgrade)
                {
                    case "moc":
                        moc += 1;
                        break;
                    case "spryt":
                        spryt += 1;
                        break;
                    case "szybkosc":
                        szybkosc += 1;
                        break;
                    default:
                        Console.WriteLine("Wybierz istniejącą zmienna!");
                        break;
                }
            }

            public void staty()
            {
                Console.WriteLine($"Postac to {rodzaj} ma {moc} mocy oraz {spryt} sprytu.");
            }
        }
    }
}

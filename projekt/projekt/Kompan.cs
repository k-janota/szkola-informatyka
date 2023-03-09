using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Kompan
    {
        public string rodzaj;
        public int intelekt;
        public int postrach;
        public int cierpliwosc;

        public Kompan()
        {
            rodzaj = string.Empty;
            intelekt = 0;
            postrach = 0;
            cierpliwosc = 0;
        }
        public class Wybor1 : Kompan
        {
            public void ZestawyKompana()
            {
                Console.WriteLine("Wybierz postać: 1 - Matematyczka, 2 - Informatyk, 3 - Wozny, 4 - WFista");
                int numer = int.Parse(Console.ReadLine());
                switch (numer)
                {
                    case 1:
                        rodzaj = "Matematyczka";
                        intelekt = 10;
                        postrach = 10;
                        cierpliwosc = 10;
                        break;
                    case 2:
                        rodzaj = "Informatyk";
                        intelekt = 14;
                        postrach = 2;
                        cierpliwosc = 14;
                        break;
                    case 3:
                        rodzaj = "Wozny";
                        intelekt = 1;
                        postrach = 28;
                        cierpliwosc = 1;
                        break;
                    case 4:
                        rodzaj = "WFista";
                        intelekt = 1;
                        postrach = 15;
                        cierpliwosc = 14;
                        break;
                    default:
                        Console.WriteLine("Sprawdz czy jest taki Kompan!");
                        break;
                }
            }

            public void UpgradeKompan(string Upgrade1)
            {
                switch (Upgrade1)
                {
                    case "intelekt":
                        intelekt += 1;
                        break;
                    case "postrach":
                        postrach += 1;
                        break;
                    case "cierpliwosc":
                        cierpliwosc += 1;
                        break;
                    default:
                        Console.WriteLine("Wybierz istniejącą zmienna!");
                        break;
                }
            }

            public void StatyKompan()
            {
                Console.WriteLine($"Postac to {rodzaj} ma {postrach} postrachu oraz {intelekt} intelektu,a takze {cierpliwosc} cierpliwosci.");
            }
        }
    }
}

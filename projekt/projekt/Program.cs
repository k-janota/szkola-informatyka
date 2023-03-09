using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zaczynamy?");
            Sprawdz sprawdz = new Sprawdz();
            while (sprawdz.czy1 == true)
            {
                Console.WriteLine("Tak - a \t Nie - b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Console.WriteLine("Zaczynajmy!");   
                }
                else if (inp == "b")
                {
                    Console.WriteLine("Wpadles w spirale gry i zaczales gre. Nie ma odwrotu");
                }
                Console.WriteLine("---------------------------------------------------");
                Kompan.Wybor1 kompan = new Kompan.Wybor1();
                Postac.Wybor postac = new Postac.Wybor();
                postac.ZestawyPostaci();
                kompan.ZestawyKompana();
                sprawdz.czy1 = false;
                sprawdz.czy2 = true;
                Console.WriteLine();
                Console.WriteLine(postac.rodzaj);
                Console.WriteLine(kompan.rodzaj);
                while (sprawdz.czy2 == true)
                {
                    Console.WriteLine("Spotykasz potwora. Czy chcesz z nim zawalczyc?");
                    Console.WriteLine("Tak - a \t Nie - b");
                    string inp1 = Console.ReadLine();
                    if (inp1 == "a")
                    {
                        Console.WriteLine("Potwor okazal sie malo grozny i ma po 3 kazdej statystyki");
                        Console.WriteLine("Wykorzystujesz swoj spryt - a \t moc - b \t szybkosc - c");
                        string inp2 = Console.ReadLine();
                        if (inp2 == "a" && postac.spryt > 3)
                        {
                            Console.WriteLine("Zwyciezasz");
                            Console.WriteLine("---------------------------------------------------");
                            sprawdz.czy2 = false;
                            sprawdz.czy3 = true;
                        }
                        else if (inp2 == "b" && postac.moc > 3)
                        {
                            Console.WriteLine("Zwyciezasz");
                            Console.WriteLine("---------------------------------------------------");
                            sprawdz.czy2 = false;
                            sprawdz.czy3 = true;
                        }
                        else if (inp2 == "c" && postac.szybkosc > 3)
                        {
                            Console.WriteLine("Zwyciezasz");
                            Console.WriteLine("---------------------------------------------------");
                            sprawdz.czy2 = false;
                            sprawdz.czy3 = true;
                        }
                        else
                        {
                            Console.WriteLine("Przybywa twoj kompan i pomaga ci w zwalczeniu potwora.");
                            Console.WriteLine("---------------------------------------------------");
                            sprawdz.czy2 = false;
                            sprawdz.czy3 = true;
                        }
                    }
                    else if (inp1 == "b")
                    {
                        Console.WriteLine("Idziesz dalej");
                        sprawdz.czy2 = false;
                        sprawdz.czy3 = true;
                        Console.WriteLine("---------------------------------------------------");
                    }
                    while(sprawdz.czy3 == true)
                    {
                        Console.WriteLine("Dostales lvlup");
                        Console.WriteLine("Co chcesz ulepszyć u postaci: moc - moc \t szybkosc - szybkosc \t spryt - spryt Jak nic to wywalone");
                        string upg1 = Console.ReadLine();
                        postac.Upgrade(upg1);
                        Console.WriteLine("Co chcesz ulepszyć u kompana: intelekt - intelekt \t cierpliwosc - cierpliwosc \t postrach - postrach Jak nic to wywalone");
                        string upg2 = Console.ReadLine();
                        kompan.UpgradeKompan(upg2);
                        sprawdz.czy3 = false;
                        sprawdz.czy4 = true;
                        while (sprawdz.czy4 == true)
                        {
                            Console.WriteLine("Zaczepia cie boss");
                            Boss boss = new Boss();
                            boss.StatyBoss();
                            Console.WriteLine("Szybko dochodzisz do wniosku z kompanem ze czas na cios ostateczny");
                            Console.WriteLine("Wykorzystujesz cios ostateczny tak - a \t nie - b");
                            string inp3 = Console.ReadLine();
                            if (inp3 == "a")
                            {
                                Console.WriteLine("Cios ostateczny");
                                Console.WriteLine("---------------------------------------------------");
                                Console.WriteLine("Kolanami na ryj");
                                Console.WriteLine("---------------------------------------------------");
                                Console.WriteLine("Zwycięstwo");
                                Console.WriteLine("Boss ostatnim westchnieniem mowi");
                                boss.RodzniaBossa();
                                Console.WriteLine("---------------------------------------------------");
                                sprawdz.czy4 = false;
                            }
                            else if (inp3 == "b")
                            {
                                Console.WriteLine("Giniesz.");
                                Console.WriteLine("GAME OVER");
                                sprawdz.czy4 = false;
                            }
                        }
                    }
                }

            }
        }
    }
}

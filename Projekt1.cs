using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czy chcesz rozpoczac rozgrywke?");
            bool czy = true;
            while (czy)
            {
                Console.WriteLine("Tak - a \t Nie - b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Console.WriteLine("Czy masz ukończone 18 lat?");
                    Console.WriteLine("Tak - a \t Nie - b");
                    string inp32 = Console.ReadLine();
                    if (inp32 == "a")
                    {
                        Console.WriteLine("Cieszy mnie to ze jestes gotowy na rozgrywke");
                        Console.WriteLine("Zaczynajmy");
                        czy = false;
                    }
                    else if (inp32 == "b")
                    {
                        Console.WriteLine("Dorosnij, albo idz po rodzica aby udzielil zgody na gre w ta gre");
                        return;
                    }
                }
                else if (inp == "b")
                {
                    Console.WriteLine("Jezeli sie juz zastanowisz to wroc i zagraj a narazie milego dnia");
                    return;
                }
                else
                {
                    Console.WriteLine("Wlaczylem gre na nowo. Uzupelnij dane na nowo tym razem dobrze");
                    Console.WriteLine("---------------------------------------------------");
                    return;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Idziesz przez las. Spotykasz opuszczony dom. Wchodzisz do srodka?");
                Console.WriteLine("Tak - a \t Nie - b");
                string inp1 = Console.ReadLine();
                bool czy1 = true;
                while (czy1)    
                {

                    if (inp1 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do srodka");
                        czy1 = false;
                    }
                    else if (inp1 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Idziesz dalej i spotykasz kolege ktory zacheca cie do wejscia do domu");
                        czy1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Idziesz przez las. Spotykasz opuszczony dom. Wchodzisz do srodka?");
                        Console.WriteLine("Tak - a \t Nie - b");
                        inp1 = Console.ReadLine();
                    }
                }
                Console.WriteLine("W domu sa 4 pomiszczenia. Ktore wybierasz?");
                Console.WriteLine("Salon - a \t Pokoj dziecka - b \t Piwnica - c \t Lazienka - d");
                string inp2 = Console.ReadLine();
                bool czy2 = true;
                while (czy2)
                {

                    if (inp2 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Salonu");
                        Console.WriteLine("Spotykasz 80 letniego dziadka, ktory mowi ze Polska zostanie mistrzem swiata w pilke nozna");
                        Console.WriteLine("Wraz z kolega bardzo mocno zaczynacie sie smiac");
                        Console.WriteLine("Starszy pan po chwili do was dolaczyl");
                        czy2 = false;
                    }
                    else if (inp2 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Pokoju Dziecka");
                        Console.WriteLine("Niestety nikogo nie zastales w pokoju, lecz na podlodze lezy zdjecie mlodego chlopca");
                        Console.WriteLine("Obok lezy skrawek artykułu z wypadkiem samochodowym z malym chlopcem. Szybko polaczyles fakty");
                        czy2 = false;
                    }
                    else if (inp2 == "c")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Piwnicy");
                        Console.WriteLine("W piwnicy stoi stary fortepian oraz kilkadziesiat sloikow z ogorkami");
                        Console.WriteLine("Masz niesamowia ochote wziac jeden sloik otworzyc aby sprobowac.");
                        Console.WriteLine("Gdy probiujesz odkrecic sloik na twoja reke wbiega wielki pajak upuszczasz sloik i go rozbijasz. Postanawiasz oddalic sie od  miejsca zbrodni");
                        czy2 = false;
                    }
                    else if (inp2 == "d")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Lazienka");
                        Console.WriteLine("Pood prysznicem znajdujesz skrzynie pelna mydla w plynie.");
                        Console.WriteLine("Postanawiasz zanurzyc w tym reke i okazuje sie ze w srodku zyja niesmiertelene zwierzeta ktore przzyja wojne atomowa aka karaluchy");
                        Console.WriteLine("Z piskiem wybiegasz z pokoju");
                        czy2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Wybierz jeszcze raz");
                        inp2 = Console.ReadLine();
                    }
                }
                Console.WriteLine("Opuszczasz domek i idziesz na obiad");
                Console.WriteLine("Koniec gry. Dziekuje za przejscie.");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Bedzie 6?");
                Console.WriteLine("Tak - a");
                string inp3 = Console.ReadLine();
                bool czy3 = true;
                while (czy3)
                {

                    if (inp3 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Dziekuje i dowidzenia");
                        czy3 = false;
                    }
                    else if (inp3 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Popraw odpoowiedz");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Dam ci 2 szanse.");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}

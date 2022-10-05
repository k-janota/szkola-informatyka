using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            int total = 0;

            var vowels = new HashSet<char> { 'a','ą','ę', 'e', 'i', 'o', 'u','ó','y', };

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    total++;
                }
                Console.WriteLine(sentence[i]);
            }
            Console.WriteLine("Your total number of vowels is: {0}", total);

            Console.ReadLine();
        }
    }
}

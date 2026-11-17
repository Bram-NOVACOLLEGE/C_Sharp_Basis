using System;

namespace Opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad het geluksgetal (voer een cijfer in):");

            ConsoleKeyInfo toets = Console.ReadKey();
            char invoer = toets.KeyChar;

            Console.WriteLine();

            if (invoer == '3')
            {
                Console.WriteLine("Correct! Mijn geluksgetal is 3!");
            }
            else if (char.IsDigit(invoer))
            {
                Console.WriteLine($"{invoer} is niet juist.");
            }
            else
            {
                Console.WriteLine($"{invoer} is niet juist. Voer een cijfer in.");
            }

            Console.ReadLine();
        }
    }
}
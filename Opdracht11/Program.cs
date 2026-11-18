using System;

namespace Opdracht11
{
    class Program
    {
        static void Main(string[] args)
        {
            char keuze = ' ';

            while (keuze != '3')
            {
                Console.WriteLine("Kies 1, 2 of 3:");
                keuze = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (keuze)
                {
                    case '1':
                        Console.WriteLine("Menu 1");
                        break;
                    case '2':
                        Console.WriteLine("Menu 2");
                        break;
                    case '3':
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                        break;
                }
            }
        }
    }
}
using System;

namespace Opdracht9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Kies een drankmaat (1/small, 2/medium, 3/large):");
            string keuze = Console.ReadLine().ToLower();

            switch (keuze)
            {
                case "1":
                case "small":
                    Console.WriteLine("€ 2,00");
                    break;
                case "2":
                case "medium":
                    Console.WriteLine("€ 2,50");
                    break;
                case "3":
                case "large":
                    Console.WriteLine("€ 3,00");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }

            Console.ReadLine();
        }
    }
}
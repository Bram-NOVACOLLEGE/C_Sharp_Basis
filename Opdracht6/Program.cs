using System;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je geboortejaar?");
            int geboortejaar = int.Parse(Console.ReadLine());

            int leeftijd = DateTime.Now.Year - geboortejaar;

            Console.WriteLine($"Je bent {leeftijd} jaar oud.");
            Console.ReadLine();
        }
    }
}
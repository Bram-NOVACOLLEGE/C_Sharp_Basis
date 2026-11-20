using System;
using System.Collections.Generic;

namespace Opdracht18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();

            foreach (Klant klant in klanten)
            {
                Console.Write(klant.Id);
                Console.Write(" ");
                Console.Write(klant.Naam);
                Console.Write(" ");
                Console.WriteLine(klant.Telefoonnummer);
            }

            Console.ReadLine();
        }
    }
}
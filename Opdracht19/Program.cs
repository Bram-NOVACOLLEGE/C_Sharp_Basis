using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();

            Console.WriteLine("1. Klanten gesorteerd op naam:");
            var gesorteerd = klanten.OrderBy(k => k.Naam);
            foreach (Klant klant in gesorteerd)
            {
                Console.Write(klant.Id);
                Console.Write("\t");
                Console.Write(klant.Naam);
                Console.Write("\t\t");
                Console.WriteLine(klant.Telefoonnummer);
            }

            Console.WriteLine();

            Console.WriteLine("2. Klanten met telefoonnummer 0612345:");
            var gefilterd = klanten.Where(k => k.Telefoonnummer.StartsWith("0612345"));
            foreach (Klant klant in gefilterd)
            {
                Console.Write(klant.Id);
                Console.Write("\t");
                Console.Write(klant.Naam);
                Console.Write("\t\t");
                Console.WriteLine(klant.Telefoonnummer);
            }

            Console.WriteLine();

            Console.WriteLine("3. Totaal aantal klanten:");
            Console.WriteLine(klanten.Count());

            Console.WriteLine();

            Console.WriteLine("4. Eerste klant in de gesorteerde lijst:");
            Console.WriteLine(gesorteerd.First().Naam);

            Console.ReadLine();
        }
    }
}
using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer de breedte in:");
            string breedteInvoer = Console.ReadLine();
            double breedte = double.Parse(breedteInvoer);

            Console.WriteLine("Voer de hoogte in:");
            string hoogteInvoer = Console.ReadLine();
            double hoogte = double.Parse(hoogteInvoer);

            double oppervlakte = breedte * hoogte;

            Console.WriteLine("De oppervlakte is: " + string.Format("{0:F2}", oppervlakte));
            Console.ReadLine();
        }
    }
}
using System;

namespace Opdracht16
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1 = VraagGetal("Voer getal 1 in:");
            double getal2 = VraagGetal("Voer getal 2 in:");

            int keuze = 0;

            while (keuze != 1 && keuze != 2 && keuze != 3)
            {
                Console.WriteLine("Kies een bewerking:");
                Console.WriteLine("1 = optellen & aftrekken");
                Console.WriteLine("2 = optellen & vermenigvuldigen");
                Console.WriteLine("3 = optellen & delen");

                int.TryParse(Console.ReadLine(), out keuze);

                if (keuze != 1 && keuze != 2 && keuze != 3)
                {
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                }
            }

            switch (keuze)
            {
                case 1:
                    Console.WriteLine($"Optellen: {Optellen(getal1, getal2)}");
                    Console.WriteLine($"Aftrekken: {Aftrekken(getal1, getal2)}");
                    break;
                case 2:
                    Console.WriteLine($"Optellen: {Optellen(getal1, getal2)}");
                    Console.WriteLine($"Vermenigvuldigen: {Vermenigvuldigen(getal1, getal2)}");
                    break;
                case 3:
                    Console.WriteLine($"Optellen: {Optellen(getal1, getal2)}");
                    Console.WriteLine($"Delen: {Delen(getal1, getal2)}");
                    break;
            }

            Console.ReadLine();
        }

        static double VraagGetal(string vraag)
        {
            double getal = 0;
            bool geldig = false;

            while (!geldig)
            {
                Console.WriteLine(vraag);
                string invoer = Console.ReadLine();

                if (double.TryParse(invoer, out getal))
                {
                    geldig = true;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                }
            }

            return getal;
        }

        static double Optellen(double a, double b)
        {
            return a + b;
        }

        static double Aftrekken(double a, double b)
        {
            return a - b;
        }

        static double Vermenigvuldigen(double a, double b)
        {
            return a * b;
        }

        static double Delen(double a, double b)
        {
            return a / b;
        }
    }
}
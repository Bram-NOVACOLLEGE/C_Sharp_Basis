using System;

namespace Opdracht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[5];

            for (int i = 0; i < getallen.Length; i++)
            {
                bool geldig = false;

                while (!geldig)
                {
                    Console.WriteLine($"Voer getal {i + 1} in:");
                    string invoer = Console.ReadLine();

                    if (int.TryParse(invoer, out getallen[i]))
                    {
                        geldig = true;
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Voer een geldig geheel getal in.");
                    }
                }
            }

            Console.WriteLine("Dit zijn de ingevoerde getallen:");

            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }

            Console.ReadLine();
        }
    }
}
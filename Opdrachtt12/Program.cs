using System;

namespace Opdracht12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namen = new string[5];

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Voer naam {i + 1} in:");
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine("Dit zijn de ingevoerde namen:");

            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }

            Console.ReadLine();
        }
    }
}
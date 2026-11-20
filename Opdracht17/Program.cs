using System;

namespace Opdracht17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel plekken moet de array hebben?");
            string invoer = Console.ReadLine();

            try
            {
                int lengte = int.Parse(invoer);
                string[] namen = new string[lengte];

                for (int i = 0; i < namen.Length; i++)
                {
                    namen[i] = $"Naam {i + 1}";
                }

                Console.WriteLine($"Array aangemaakt met {namen.Length} plekken:");

                foreach (string naam in namen)
                {
                    Console.WriteLine(naam);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Dat is geen geldig geheel getal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ongeldige lengte: het getal is te groot of negatief.");
            }
            catch (Exception)
            {
                Console.WriteLine("Er ging iets mis bij het aanmaken van de array.");
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace Opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad het gelukswoord:");

            string invoer = Console.ReadLine().ToUpper();

            if (invoer == "LUCKY")
            {
                Console.WriteLine($"Je typte {invoer} en dat is Correct!");
            }
            else
            {
                Console.WriteLine($"Je typte {invoer} en dat is Fout!");
            }

            Console.ReadLine();
        }
    }
}
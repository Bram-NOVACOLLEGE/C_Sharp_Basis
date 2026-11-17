using System;

namespace Opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad het gelukswoord:");

            string invoer = Console.ReadLine().ToUpper();

            string resultaat = (invoer == "LUCKY")
                ? $"Je typte {invoer} en dat is Correct!"
                : $"Je typte {invoer} en dat is Fout!";

            Console.WriteLine(resultaat);
            Console.ReadLine();
        }
    }
}
using System;

namespace Opdracht15
{
    class Rekenmachine
    {
        public static int Optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int uitkomst = Rekenmachine.Optellen(4, 7);
            Console.WriteLine("De som is: " + uitkomst);
            Console.ReadLine();
        }
    }
}
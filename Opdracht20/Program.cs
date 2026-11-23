using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> cijfers = new List<double>();
            string invoer = "";
            double getal;

            while (invoer != "stop")
            {
                Console.WriteLine("Voer een of meerdere cijfers in, als je wilt stoppen, typ stop.");
                invoer = Console.ReadLine();

                if (double.TryParse(invoer, out getal))
                {
                    if (getal >= 1.0 && getal <= 10.0)
                    {
                        cijfers.Add(getal);
                    }
                    else
                    {
                        Console.WriteLine("Het cijfer moet tussen 1,0 en 10,0 liggen.");
                    }
                }
            }

            Console.WriteLine();

            double gemiddelde = cijfers.Average();
            Console.WriteLine("Gemiddelde:" + gemiddelde);

            double hoogste = cijfers.Max();
            Console.WriteLine("Hoogste:" + hoogste);

            double laagste = cijfers.Min();
            Console.WriteLine("Laagste:" + laagste);

            int voldoendes = cijfers.Where(cijfer => cijfer >= 5.5).Count();
            Console.WriteLine("Aantal voldoendes:" + voldoendes);

            Console.WriteLine();
            Console.WriteLine("Cijfers van hoog naar laag:");
            var gesorteerd = cijfers.OrderByDescending(cijfer => cijfer);
            foreach (double cijfer in gesorteerd)
            {
                Console.WriteLine(cijfer);
            }

            Console.ReadLine();
        }
    }
}
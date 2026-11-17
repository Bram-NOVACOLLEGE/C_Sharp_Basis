using System;

namespace Opdracht10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
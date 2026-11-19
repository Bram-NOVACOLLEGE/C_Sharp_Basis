namespace Opdracht14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            Console.WriteLine(tabel[2, 1]);
            Console.WriteLine(tabel[0, 0] + tabel[1, 1]);
        }
    }
}

// Opdracht 14 beredeneren //
// Ik denk dat dit stukje code een getal uit een bepaalde kolom kiest en dan ook nog een getal uit een rij in die kolom en dat hij dat dan laat zien //
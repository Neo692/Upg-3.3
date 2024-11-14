using System;

namespace upg3
{
    class Program
    {
        static void Main(string[] args)
        {
            int timpris = 80;
            int maxdagkostnad = 950;

            Console.WriteLine("Hur många timmar vill du hyra bilen? ");
            int timmar = int.Parse(Console.ReadLine());

            int kostnad = timmar * timpris;

            if (kostnad > maxdagkostnad)
            {
                kostnad = maxdagkostnad;
            }

            Console.WriteLine("Det kommer att kosta: " + kostnad + " kr");
        }
    }
}
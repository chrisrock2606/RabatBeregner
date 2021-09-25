using System;

namespace DiplomOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Rabatberegner
    {
        public double GetPrisEfterRabat(int antalVarer, double stykPris)
        {
            double bruttoPris = antalVarer * stykPris;
            double rabat = 0;
            if (bruttoPris > 1000)
            {
                // Indkøb over 1000 kr. giver 3% rabat
                rabat = 0.03;
            }
            if (antalVarer > 10)
            {
                // Flere end 10 varer giver 2% rabat
                rabat += 0.02;
            }
            bruttoPris -= rabat * bruttoPris;
            
            return bruttoPris;
        }
    }
}

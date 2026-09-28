using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.Instance;
            ChocolateBoiler boiler2 = ChocolateBoiler.Instance;

            // Controleren of het dezelfde instantie is
            Console.WriteLine(boiler1 == boiler2);

            // De boiler gebruiken
            Console.WriteLine("leeg: " + boiler1.IsEmpty);
            boiler1.fill();

            Console.WriteLine("leeg na vullen: " + boiler2.IsEmpty);
            boiler2.boil();

            Console.WriteLine("Boiled: " + boiler1.IsBoiled);
            boiler1.drain();

            Console.WriteLine("leeg na legen: " + boiler2.IsEmpty);
        }
    }
}
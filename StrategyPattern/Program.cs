using StrategyPattern.Beverages;
using StrategyPattern.Factory;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffeeFactory factory = new CoffeeFactory();

            Beverage tall = factory.CreateCoffee(CoffeeType.Espresso, SizeType.TALL);
            Beverage grande = factory.CreateCoffee(CoffeeType.Espresso, SizeType.GRANDE);
            Beverage venti = factory.CreateCoffee(CoffeeType.CaffeAffogato, SizeType.VENTI);
            PrintBeverage(tall);
            PrintBeverage(grande);
            PrintBeverage(venti);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + "  $" + beverage.Cost().ToString());
        }
    }
}
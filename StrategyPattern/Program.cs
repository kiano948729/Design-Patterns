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

            Beverage tall = factory.OrderDrink(
                CoffeeType.Espresso,
                SizeType.TALL
            );

            Beverage grande = factory.OrderDrink(
                CoffeeType.Espresso,
                SizeType.GRANDE
            );

            Beverage venti = factory.OrderDrink(
                CoffeeType.CaffeAffogato,
                SizeType.VENTI
            );
        }
    }
}
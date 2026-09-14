using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using StrategyPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage doppio = new Espresso();
            doppio = new Water(doppio);
            PrintBeverage(doppio);

            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
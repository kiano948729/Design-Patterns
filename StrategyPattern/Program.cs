using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using StrategyPattern.Beverages;
using StrategyPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //espresso
            Beverage espresso = new Espresso();
            PrintBeverage("espresso", espresso);

            //doppio
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            PrintBeverage("doppio", doppio);

            //lungo
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage("lungo", lungo);

            //macchiato
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage("macchiato", macchiato);

            //con Panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage("con Panna", conPanna);

            //cappuccino
            Beverage cappuccino = new Espresso();
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage("cappuccino", cappuccino);

            //americano
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage("americano", americano);

            //caffé Latte
            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage("caffé Latte", caffeLatte);

            //flat White
            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage("flat White", flatWhite);

            //romana
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage("romana", romana);

            //morocchino
            Beverage morocchino = new Espresso();
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage("morocchino", morocchino);

            //mocha
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage("mocha", mocha);

            //bicerin
            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage("bicerin", bicerin);

            //breve
            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            PrintBeverage("breve", breve);

            //raf Coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new IceCream(rafCoffee);
            PrintBeverage("raf Coffee", rafCoffee);

            //mead raf
            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new IceCream(meadRaf);
            PrintBeverage("mead raf", meadRaf);

            //galao
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage("galao", galao);

            //caffé affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage("caffé affogato", caffeAffogato);

            //vienna Coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage("vienna Coffee", viennaCoffee);

            //glace
            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            PrintBeverage("glace", glace);

            //chocolate Milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage("chocolate Milk", chocolateMilk);

            //demi - créme
            Beverage demiCreme = new Espresso();
            demiCreme = new Espresso(demiCreme);
            demiCreme = new IceCream(demiCreme);
            demiCreme = new IceCream(demiCreme);
            PrintBeverage("demi - créme", demiCreme);

            //latte macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage("latte macchiato", latteMacchiato);

            //freddo
            Beverage freddo = new Espresso();
            freddo = new Ice(freddo);
            PrintBeverage("freddo", freddo);

            //frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage("frappuccino", frappuccino);

            //caramel Frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new IceCream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage("caramel Frappuccino", caramelFrappuccino);

            //frappe
            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage("frappe", frappe);

            //irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage("irish Coffee", irishCoffee);
        }

        static void PrintBeverage(string name, Beverage beverage)
        {
            Console.WriteLine(name + " - " + beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
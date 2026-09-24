using StrategyPattern.Beverages;
using StrategyPattern.Ingredients;

namespace StrategyPattern.Factory
{
    internal class CoffeeFactory : ICoffeeFactory
    {
        public Beverage CreateCoffee(CoffeeType type, SizeType size)
        {
            Coffee coffee;

            switch (type)
            {
                case CoffeeType.Espresso:
                    coffee = new Coffee("Espresso", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    break;

                case CoffeeType.Doppio:
                    coffee = new Coffee("Doppio", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    break;

                case CoffeeType.Lungo:
                    coffee = new Coffee("Lungo", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Water", 0.10));
                    break;

                case CoffeeType.Macchiato:
                    coffee = new Coffee("Macchiato", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.Corretta:
                    coffee = new Coffee("Corretta", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Liquor", 0.75));
                    break;

                case CoffeeType.ConPanna:
                    coffee = new Coffee("Con Panna", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                case CoffeeType.Cappuccino:
                    coffee = new Coffee("Cappuccino", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.Americano:
                    coffee = new Coffee("Americano", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Water", 0.10));
                    break;

                case CoffeeType.CaffeLatte:
                    coffee = new Coffee("Caffe Latte", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.FlatWhite:
                    coffee = new Coffee("Flat White", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    break;

                case CoffeeType.Romana:
                    coffee = new Coffee("Romana", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Lemon", 0.15));
                    break;

                case CoffeeType.Morocchino:
                    coffee = new Coffee("Morocchino", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Chocolate", 0.30));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.Mocha:
                    coffee = new Coffee("Mocha", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Chocolate", 0.30));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                case CoffeeType.Bicerin:
                    coffee = new Coffee("Bicerin", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Black Chocolate", 0.30));
                    coffee.AddIngredient(new Ingredient("White Chocolate", 0.30));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                case CoffeeType.Breve:
                    coffee = new Coffee("Breve", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Half Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.RafCoffee:
                    coffee = new Coffee("Raf Coffee", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Vanilla Sugar", 0.20));
                    coffee.AddIngredient(new Ingredient("Cream", 0.30));
                    break;

                case CoffeeType.MeadRaf:
                    coffee = new Coffee("Mead Raf", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Honey", 0.20));
                    coffee.AddIngredient(new Ingredient("Cream", 0.30));
                    break;

                case CoffeeType.Galao:
                    coffee = new Coffee("Galao", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.CaffeAffogato:
                    coffee = new Coffee("Caffe Affogato", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Ice Cream", 0.50));
                    break;

                case CoffeeType.ViennaCoffee:
                    coffee = new Coffee("Vienna Coffee", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                case CoffeeType.Glace:
                    coffee = new Coffee("Glace", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Ice Cream", 0.50));
                    break;

                case CoffeeType.ChocolateMilk:
                    coffee = new Coffee("Chocolate Milk", size);
                    coffee.AddIngredient(new Ingredient("Cocoa", 0.30));
                    coffee.AddIngredient(new Ingredient("Milk", 0.20));
                    break;

                case CoffeeType.DemiCreme:
                    coffee = new Coffee("Demi-Creme", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Cream", 0.30));
                    break;

                case CoffeeType.LatteMacchiato:
                    coffee = new Coffee("Latte Macchiato", size);
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Milk Foam", 0.20));
                    break;

                case CoffeeType.Freddo:
                    coffee = new Coffee("Freddo", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Liquor", 0.75));
                    coffee.AddIngredient(new Ingredient("Ice", 0.10));
                    break;

                case CoffeeType.Frappuccino:
                    coffee = new Coffee("Frappuccino", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                case CoffeeType.CaramelFrappuccino:
                    coffee = new Coffee("Caramel Frappuccino", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Ice", 0.10));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Cream and Syrup", 0.25));
                    break;

                case CoffeeType.Frappe:
                    coffee = new Coffee("Frappe", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Steamed Milk", 0.20));
                    coffee.AddIngredient(new Ingredient("Ice Cream", 0.50));
                    break;

                case CoffeeType.IrishCoffee:
                    coffee = new Coffee("Irish Coffee", size);
                    coffee.AddIngredient(new Ingredient("Espresso", 1.00));
                    coffee.AddIngredient(new Ingredient("Whiskey", 0.75));
                    coffee.AddIngredient(new Ingredient("Whipped Cream", 0.10));
                    break;

                default:
                    throw new ArgumentException("niet bestaande koffie :-)");
            }

            return coffee;
        }
    }
}

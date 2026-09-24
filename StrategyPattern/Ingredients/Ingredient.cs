using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ingredients
{
    internal class Ingredient
    {
        public string Name { get; }
        public double Price { get; }

        public Ingredient(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}

using StrategyPattern.Factory;
using StrategyPattern.Ingredients;
using System.Collections.Generic;

namespace StrategyPattern.Beverages
{
    internal class Coffee : Beverage
    {
        private readonly string name;
        private readonly List<Ingredient> ingredients;
        private readonly SizeType size;

        public Coffee(string name, SizeType size)
        {
            this.name = name;
            this.size = size;
            ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public override string GetDescription()
        {
            if (ingredients.Count == 0)
            {
                return name + " (" + size + ")";
            }

            List<string> descriptions = new List<string>();

            foreach (Ingredient ingredient in ingredients)
            {
                descriptions.Add(ingredient.Name);
            }

            return name + " (" + size + ") - " + string.Join(", ", descriptions);
        }

        public override double Cost()
        {
            double total = 0;

            foreach (Ingredient ingredient in ingredients)
            {
                total += ingredient.Price;
            }

            switch (size)
            {
                case SizeType.TALL:
                    return total;

                case SizeType.GRANDE:
                    return total * 1.5;

                case SizeType.VENTI:
                    return total * 2;

                default:
                    return total;
            }
        }
    }
}

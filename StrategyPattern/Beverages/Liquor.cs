using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Beverages
{
    internal class Liquor : Beverage
    {
        public Liquor(Beverage beverage = null)
        {
            description = "Liquor";
            this.baseBeverage = beverage;
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }

        public override double cost()
        {
            double price = 0.75 * ((int)Size + 1);

            if (baseBeverage != null)
            {
                return price + baseBeverage.cost();
            }

            return price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso(Beverage beverage = null)
        {
            description = "Espresso";
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
            double price = 1.99 * ((int)Size + 1);

            if (baseBeverage != null)
            {
                return price + baseBeverage.cost();
            }

            return price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Beverages;

namespace StrategyPattern.Factory
{
    internal interface ICoffeeFactory
    {
        Beverage CreateCoffee(CoffeeType type, SizeType size);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Beverages
{
    internal abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract double Cost();
    }
}

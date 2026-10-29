using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sorting
{
    internal class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck duck)
        {
            if (duck == null)
            {
                return 1;
            }

            return this.weight.CompareTo(duck.weight);
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}

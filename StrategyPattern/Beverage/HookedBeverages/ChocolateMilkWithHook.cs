using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Beverage.HookedBeverages
{
    internal class ChocolateMilkWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding whipped cream");
        }
        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like whipcream with your chocolate milk? (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}

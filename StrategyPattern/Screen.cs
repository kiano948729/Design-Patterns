using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen omhoog");
        }
        public void Down() 
        {
            Console.WriteLine("Screen omlaag");
        }
    }
}

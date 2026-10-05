using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater lights aan");
        }

        public void Off()
        {
            Console.WriteLine("Theater lights uit");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Theater lights dim tot {value}");
        }
    }
}

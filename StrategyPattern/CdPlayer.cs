using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CD player aan");
        }
        public void Off()
        {
            Console.WriteLine("CD player uit");
        }
        public void Eject()
        {
            Console.WriteLine("CD player uitwerpen");
        }
        public void Pause()
        {
            Console.WriteLine("CD player pauzeren");
        }
        public void Play()
        {
            Console.WriteLine("CD player afspelen");
        }
        public void Stop()
        {
            Console.WriteLine("CD player stoppen");
        }
    }
}

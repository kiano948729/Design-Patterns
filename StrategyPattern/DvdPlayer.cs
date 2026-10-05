using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD player aan");
        }
        public void Off()
        {
            Console.WriteLine("DVD player uit");
        }
        public void Eject()
        {
            Console.WriteLine("DVD player uitwerpen");
        }
        public void Pause()
        {
            Console.WriteLine("DVD player pauzeren");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"DVD player speelt {movie} af");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD player zet surround audio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DVD player zet 2 kanaals audio");
        }
        public void Stop()
        {
            Console.WriteLine("DVD player stoppen");
        }
    }
}

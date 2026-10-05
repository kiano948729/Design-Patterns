using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier aan");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier uit");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
            Console.WriteLine("Amplifier zet CD player");
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier zet DVD player");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier stereo geluid");

        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround geluid");

        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
            Console.WriteLine("Amplifier zet tuner");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier zet volume");
        }

    }
}

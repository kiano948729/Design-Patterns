using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector aan");
        }

        public void Off()
        {
            Console.WriteLine("Projector uit");
        }


        public void TvMode()
        {
            Console.WriteLine("Projector tv mode");
        }

        public void WideScreenMode()
        {

        }
    }
}

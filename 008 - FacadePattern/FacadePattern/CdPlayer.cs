using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
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
            Console.WriteLine("CD Player on");
        }
        public void Off()
        {
            Console.WriteLine("CD Player off");
        }
        public void Eject()
        {
            Console.WriteLine("CD Player eject");
        }
        public void Pause()
        {
            Console.WriteLine("CD Player pause");
        }
        public void Play()
        {
            Console.WriteLine("CD Player play");
        }
        public void Stop()
        {
            Console.WriteLine("CD Player stop");
        }
    }
}

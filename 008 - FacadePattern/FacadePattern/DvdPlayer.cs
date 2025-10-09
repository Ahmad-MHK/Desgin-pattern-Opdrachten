using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
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
            Console.WriteLine("DVD Player on");
        }
        public void Off()
        {
            Console.WriteLine("DVD Player off");
        }
        public void Eject()
        {
            Console.WriteLine("DVD Player eject");
        }
        public void Pause()
        {
            Console.WriteLine("DVD Player pause");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"DVD Player playing \"{movie}\"");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD Player surround audio set");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DVD Player two-channel audio set");
        }
        public void Stop()
        {
            Console.WriteLine("DVD Player stop");
        }
    }
}

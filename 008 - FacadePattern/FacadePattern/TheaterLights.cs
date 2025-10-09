using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }

        public void Off()
        {
            Console.WriteLine("Theater Ceiling Lights off");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Theater Ceiling Lights dimming to {value}%");
        }
    }
}

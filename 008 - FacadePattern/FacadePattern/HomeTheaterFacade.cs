using System;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(
            Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("[Facade] Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();

            _lights.Dim(10);
            _screen.Down();

            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();

            _amp.On();
            _amp.SetDvd(_dvdPlayer);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("[Facade] Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
        }
    }
}

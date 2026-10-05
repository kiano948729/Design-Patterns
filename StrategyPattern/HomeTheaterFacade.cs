namespace StrategyPattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amp;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private PopcornPopper _popcornPopper;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _lights;
        private Tuner _tuner;

        public HomeTheaterFacade(
            Amplifier amp,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            PopcornPopper popcornPopper,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            Tuner tuner)
        {
            _amp = amp;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _popcornPopper.On();
            _popcornPopper.Pop();

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
            Console.WriteLine("Shutting movie theater down...");

            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();

            _amp.Off();

            _projector.Off();

            _screen.Up();

            _lights.On();

            _popcornPopper.Off();
        }
    }
}

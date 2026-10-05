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

        public void ListenToCd(string cdTitle)
        {
            Console.WriteLine("Klaar voor een audiophile ervaring");
            _lights.On();
            _amp.On();
            _amp.SetCd(_cdPlayer);
            _amp.SetStereoSound();
            _amp.SetVolume(5);
            _cdPlayer.On();
        }
        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Luisteren op de radio");
            _tuner.On();
            _tuner.setFrequency();
            _amp.On();
            _amp.SetTuner(_tuner);
            _amp.SetVolume(5);
        }
        public void EndCd()
        {
            Console.WriteLine("CD afsluiten");
            _amp.Off();
            _cdPlayer.Eject();
            _cdPlayer.Off();
        }
    }
}

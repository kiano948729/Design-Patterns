namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp,
                dvdPlayer,
                cdPlayer,
                popcornPopper,
                projector,
                screen,
                lights,
                tuner);

            homeTheater.WatchMovie("john wick");

            //voor het stoppen van de film
            homeTheater.EndMovie();
        }
    }
}
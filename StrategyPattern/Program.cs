using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.Swim();

            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.Swim();

            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.Swim();

            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.Swim();

            robotDuck.Display();
            robotDuck.PerformQuack();
            robotDuck.PerformFly();
            robotDuck.Swim();
        }
    }
}
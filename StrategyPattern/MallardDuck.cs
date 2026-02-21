namespace DesignPatterns.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyAway();
            quackBehavior = new QuackSound();
        }
    }
}

using DesignPatterns.StrategyPattern.Behavior;

namespace DesignPatterns.StrategyPattern.Duck
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

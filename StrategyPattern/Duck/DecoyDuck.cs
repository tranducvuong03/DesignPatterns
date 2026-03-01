using DesignPatterns.StrategyPattern.Behavior;

namespace DesignPatterns.StrategyPattern.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        } 
    }
}

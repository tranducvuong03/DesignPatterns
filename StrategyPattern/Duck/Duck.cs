using DesignPatterns.StrategyPattern.Behavior;

namespace DesignPatterns.StrategyPattern.Duck
{
    public abstract class Duck
    {
        public QuackBehavior quackBehavior;
        public FlyBehavior flyBehavior;

        public void Float()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}

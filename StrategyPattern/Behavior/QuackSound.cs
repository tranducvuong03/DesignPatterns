namespace DesignPatterns.StrategyPattern.Behavior
{
    public class QuackSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

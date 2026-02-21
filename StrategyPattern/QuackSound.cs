namespace DesignPatterns.StrategyPattern
{
    public class QuackSound : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

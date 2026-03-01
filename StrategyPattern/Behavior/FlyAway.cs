namespace DesignPatterns.StrategyPattern.Behavior
{
    public class FlyAway : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}

namespace DesignPatterns.AdapterPattern.ObjectAdapter.TargetInterface
{
    public class MallardDuck : IDuck
    {
        public void Quack() => Console.WriteLine("Quack!");
        public void Fly() => Console.WriteLine("Flying long distance");
    }
}

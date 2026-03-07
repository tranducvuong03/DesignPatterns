namespace DesignPatterns.AdapterPattern.ObjectAdapter.Adaptee
{
    public class Turkey
    {
        public void Gobble() => Console.WriteLine("Gobble gobble!");
        public void FlyShortDistance() => Console.WriteLine("Flying short distance");
    }
}

namespace DesignPatterns.DecoratorPattern.Component
{
    public class Gelato : IceCream
    {
        public Gelato() : base()
        {
            Description = "Gelato";
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}

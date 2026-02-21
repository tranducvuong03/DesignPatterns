namespace DesignPattern.DecoratorPattern
{
    public class Popsicle : IceCream
    {
        public Popsicle()
        {
            Description = "Popsicle";
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}

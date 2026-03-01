namespace DesignPatterns.DecoratorPattern.Component
{
    public abstract class IceCream
    {
        public string Description = "Unknown Ice Cream";

        public virtual string GetDescription()
        {
            return Description;
        }
    }
}

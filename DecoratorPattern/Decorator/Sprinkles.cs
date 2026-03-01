using DesignPatterns.DecoratorPattern.Component;

namespace DesignPatterns.DecoratorPattern.Decorator
{
    public class Sprinkles : IceCreamDecorator
    {
        public Sprinkles(IceCream iceCream) : base(iceCream)
        {
        }

        public override string GetDescription()
        {
            return _iceCream.GetDescription() + ", Sprinkles";
        }
    }
}

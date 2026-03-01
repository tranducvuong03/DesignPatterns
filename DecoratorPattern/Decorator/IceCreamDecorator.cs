using DesignPatterns.DecoratorPattern.Component;

namespace DesignPatterns.DecoratorPattern.Decorator
{
    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        protected IceCreamDecorator(IceCream iceCream) : base()
        {
            _iceCream = iceCream;
        }

    }
}

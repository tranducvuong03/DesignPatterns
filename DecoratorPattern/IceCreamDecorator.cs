namespace DesignPattern.DecoratorPattern
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

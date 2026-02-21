namespace DesignPattern.DecoratorPattern
{
    public class Marshmallow : IceCreamDecorator
    {
        public Marshmallow(IceCream iceCream) : base(iceCream)
        {
        }

        public override string GetDescription()
        {
            return _iceCream.GetDescription() + ", Marshmallow";
        }
    }
}

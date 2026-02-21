namespace DesignPattern.DecoratorPattern
{
    public class ChocolateSyrup : IceCreamDecorator
    {
        public ChocolateSyrup(IceCream iceCream) : base(iceCream)
        {
        }

        public override string GetDescription()
        {
            return _iceCream.GetDescription() + ", Chocolate Syrup";
        }
    }
}

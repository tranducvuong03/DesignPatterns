using DesignPatterns.AdapterPattern.ObjectAdapter.Adaptee;
using DesignPatterns.AdapterPattern.ObjectAdapter.TargetInterface;

namespace DesignPatterns.AdapterPattern.ObjectAdapter.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private readonly Turkey _turkey;

        public TurkeyAdapter(Turkey turkey) => _turkey = turkey;

        public void Quack() => _turkey.Gobble();

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
                _turkey.FlyShortDistance();
        }
    }
}

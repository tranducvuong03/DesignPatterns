using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern.Aggregate
{
    public interface IMenu
    {
        IIterator CreateIterator();
    }
}

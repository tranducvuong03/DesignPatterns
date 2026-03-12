namespace DesignPatterns.IteratorPattern.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}

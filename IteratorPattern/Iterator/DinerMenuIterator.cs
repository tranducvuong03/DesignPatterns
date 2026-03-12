using DesignPatterns.IteratorPattern.Aggregate;

namespace DesignPatterns.IteratorPattern.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public object Next()
        {
            MenuItem item = items[position];
            position++;
            return item;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            return true;
        }
    }
}

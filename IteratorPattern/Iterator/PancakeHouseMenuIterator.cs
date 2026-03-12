using DesignPatterns.IteratorPattern.Aggregate;

namespace DesignPatterns.IteratorPattern.Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> items;
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
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
            return position < items.Count;
        }
    }
}

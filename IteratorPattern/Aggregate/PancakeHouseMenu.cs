using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern.Aggregate
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K&B Pancake Breakfast",
                "Pancakes with scrambled eggs and toast",
                true, 2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}

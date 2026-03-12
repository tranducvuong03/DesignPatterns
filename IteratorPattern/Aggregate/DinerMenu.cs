using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern.Aggregate
{
    public class DinerMenu : IMenu
    {
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                "(Fake) Bacon with lettuce & tomato",
                true, 2.99);

            AddItem("BLT",
                "Bacon with lettuce & tomato",
                false, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Menu full");
            }
            else
            {
                MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}

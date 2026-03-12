using DesignPatterns.IteratorPattern.Aggregate;
using DesignPatterns.IteratorPattern.Iterator;

namespace DesignPatterns.IteratorPattern
{
    public class Waitress
    {
        private IMenu pancakeHouseMenu;
        private IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            PrintMenu(pancakeIterator);
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem item = (MenuItem)iterator.Next();

                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine("----------------");
            }
        }
    }
}

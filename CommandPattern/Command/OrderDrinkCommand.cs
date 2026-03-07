using DesignPatterns.CommandPattern.Receiver;

namespace DesignPatterns.CommandPattern.Command
{
    public class OrderDrinkCommand :ICommand
    {
        private readonly Chef _chef;
        private readonly string _drink;

        public OrderDrinkCommand(Chef chef, string drink)
        {
            _chef = chef;
            _drink = drink;
        }

        public void Execute() => _chef.MakeDrink(_drink);
        public void Undo() => _chef.CancelDrink(_drink);
    }
}

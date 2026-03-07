using DesignPatterns.CommandPattern.Receiver;

namespace DesignPatterns.CommandPattern.Command
{
    public class OrderFoodCommand : ICommand
    {
        private readonly Chef _chef;
        private readonly string _dish;

        public OrderFoodCommand(Chef chef, string dish)
        {
            _chef = chef;
            _dish = dish;
        }

        public void Execute() => _chef.CookDish(_dish);
        public void Undo() => _chef.CancelDish(_dish);
    }
}

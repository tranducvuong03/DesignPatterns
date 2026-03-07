using DesignPatterns.CommandPattern.Command;

namespace DesignPatterns.CommandPattern.Invoker
{
    public class Waiter
    {
        private readonly List<ICommand> _orderHistory = new();
        private readonly Queue<ICommand> _pendingOrders = new();

        public void TakeOrder(ICommand command)
        {
            _pendingOrders.Enqueue(command);
            Console.WriteLine("Waiter đã ghi order.");
        }

        public void PlaceOrders()
        {
            Console.WriteLine("\nWaiter gửi order xuống bếp...");
            while (_pendingOrders.Count > 0)
            {
                var command = _pendingOrders.Dequeue();
                command.Execute();
                _orderHistory.Add(command);
            }
        }

        public void CancelLastOrder()
        {
            if (_orderHistory.Count == 0)
            {
                Console.WriteLine("Không có order nào để huỷ.");
                return;
            }

            var last = _orderHistory[^1];
            last.Undo();
            _orderHistory.RemoveAt(_orderHistory.Count - 1);
        }

        public void PrintHistory()
        {
            Console.WriteLine("\nLịch sử order:");
            if (_orderHistory.Count == 0)
            {
                Console.WriteLine("  (trống)");
                return;
            }
            for (int i = 0; i < _orderHistory.Count; i++)
                Console.WriteLine($"  {i + 1}. {_orderHistory[i].GetType().Name}");
        }
    }
}

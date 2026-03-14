using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random _random = new Random();

        public HasQuarterState(GumballMachine gumballMachine) => _gumballMachine = gumballMachine;

        public void InsertQuarter() => Console.WriteLine("Bạn không thể nhét thêm xu nữa.");
        public void EjectQuarter()
        {
            Console.WriteLine("Đã trả lại đồng xu.");
            _gumballMachine.CurrentState = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("Bạn đã vặn tay cầm...");
            int winner = _random.Next(10);
            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.CurrentState = _gumballMachine.WinnerState;
            }
            else
            {
                _gumballMachine.CurrentState = _gumballMachine.SoldState;
            }
        }

        public void Dispense() => Console.WriteLine("Không có kẹo nhả ra ở bước này.");
    }
}

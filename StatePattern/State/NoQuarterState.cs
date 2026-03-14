using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine) => _gumballMachine = gumballMachine;

        public void InsertQuarter()
        {
            Console.WriteLine("Bạn vừa nhét một đồng xu.");
            _gumballMachine.CurrentState = _gumballMachine.HasQuarterState;
        }

        public void EjectQuarter() => Console.WriteLine("Bạn chưa nhét xu vào.");
        public void TurnCrank() => Console.WriteLine("Bạn vặn tay cầm, nhưng không có xu.");
        public void Dispense() => Console.WriteLine("Bạn cần trả tiền trước.");
    }
}

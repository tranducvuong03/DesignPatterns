using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine) => _gumballMachine = gumballMachine;

        public void InsertQuarter() => Console.WriteLine("Bạn không thể nhét xu, máy đã hết kẹo.");
        public void EjectQuarter() => Console.WriteLine("Bạn chưa nhét xu nào mà đòi trả lại.");
        public void TurnCrank() => Console.WriteLine("Bạn vặn tay cầm, nhưng chẳng có kẹo nào cả.");
        public void Dispense() => Console.WriteLine("Không có kẹo để nhả ra.");
    }
}

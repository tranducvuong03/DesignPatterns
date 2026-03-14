using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;
        public SoldState(GumballMachine gumballMachine) => _gumballMachine = gumballMachine;

        public void InsertQuarter() => Console.WriteLine("Xin chờ, chúng tôi đang nhả kẹo cho bạn.");
        public void EjectQuarter() => Console.WriteLine("Xin lỗi, bạn đã vặn tay cầm rồi, không trả xu được.");
        public void TurnCrank() => Console.WriteLine("Vặn tay cầm 2 lần cũng không được thêm kẹo đâu!");

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.CurrentState = _gumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Ối, hết kẹo mất rồi!");
                _gumballMachine.CurrentState = _gumballMachine.SoldOutState;
            }
        }
    }
}

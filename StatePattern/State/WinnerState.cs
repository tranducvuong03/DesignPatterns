using DesignPatterns.StatePattern.Context;

namespace DesignPatterns.StatePattern.State
{
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;
        public WinnerState(GumballMachine gumballMachine) => _gumballMachine = gumballMachine;

        public void InsertQuarter() => Console.WriteLine("Xin chờ, chúng tôi đang nhả kẹo.");
        public void EjectQuarter() => Console.WriteLine("Xin lỗi, bạn đã vặn tay cầm rồi.");
        public void TurnCrank() => Console.WriteLine("Vặn thêm cũng không có tác dụng.");

        public void Dispense()
        {
            Console.WriteLine("BẠN ĐÃ TRÚNG THƯỞNG! Bạn nhận được 2 viên kẹo cho 1 đồng xu.");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.CurrentState = _gumballMachine.SoldOutState;
            }
            else
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
}

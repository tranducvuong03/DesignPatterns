using DesignPatterns.StatePattern.State;

namespace DesignPatterns.StatePattern.Context
{
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        public IState CurrentState { get; set; }
        public int Count { get; private set; } = 0;

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            this.Count = numberGumballs;
            if (numberGumballs > 0)
            {
                CurrentState = NoQuarterState;
            }
            else
            {
                CurrentState = SoldOutState;
            }
        }

        public void InsertQuarter() => CurrentState.InsertQuarter();
        public void EjectQuarter() => CurrentState.EjectQuarter();
        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense(); 
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Một viên kẹo gôm đang lăn ra khe cắm...");
            if (Count > 0)
            {
                Count--;
            }
        }
    }
}

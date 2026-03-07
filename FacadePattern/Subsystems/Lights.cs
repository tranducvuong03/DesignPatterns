namespace DesignPatterns.FacadePattern.Subsystems
{
    public class Lights
    {
        public void Dim() => Console.WriteLine("Đèn tối dần");
        public void TurnOn() => Console.WriteLine("Đèn bật");
    }
}

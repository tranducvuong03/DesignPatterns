namespace DesignPatterns.ObserverPattern.Observer
{
    public class EmailService : IObserver
    {
        public void Update(string orderId, string status)
        {
            Console.WriteLine($"[Email] Đơn {orderId} đã chuyển sang trạng thái {status}");
        }
    }
}

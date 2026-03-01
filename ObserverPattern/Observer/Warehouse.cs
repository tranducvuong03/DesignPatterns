namespace DesignPatterns.ObserverPattern.Observer
{
    public class Warehouse : IObserver
    {
        public void Update(string orderId, string status)
        {
            if (status == "Confirmed")
                Console.WriteLine($"[Kho] Chuẩn bị hàng cho đơn {orderId}");
        }
    }
}

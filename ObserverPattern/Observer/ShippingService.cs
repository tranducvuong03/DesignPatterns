namespace DesignPatterns.ObserverPattern.Observer
{
    public class ShippingService : IObserver
    {
        public void Update(string orderId, string status)
        {
            if (status == "Shipped")
                Console.WriteLine($"[Vận chuyển] Đang giao đơn {orderId}");
        }
    }
}

namespace DesignPatterns.ObserverPattern.Observer
{
    public interface IObserver
    {
        void Update(string orderId, string status);
    }
}

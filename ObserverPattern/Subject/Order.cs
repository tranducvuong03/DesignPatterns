using DesignPatterns.ObserverPattern.Observer;

namespace DesignPatterns.ObserverPattern.Subject
{
    public class Order : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _orderId;
        private string _status;

        public Order(string orderId)
        {
            _orderId = orderId;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_orderId, _status);
            }
        }

        public void ChangeStatus(string status)
        {
            _status = status;
            NotifyObservers();
        }
    }
}

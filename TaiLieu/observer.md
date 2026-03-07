[Quay lại trang chính](../README.md)

## Observer Pattern

> Observer là mẫu thiết kế hành vi định nghĩa sự phụ thuộc một-nhiều giữa các đối tượng sao cho khi một đối tượng thay đổi trạng thái, tất cả dependents của nó được thông báo và cập nhật tự động.

Hình minh họa cấu trúc UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/observer/structure.png" width="600"/> </p>

Observer cho phép loose coupling giữa subject và observers.

Ví dụ Weather Station trong Head First

```csharp
public interface IObserver
{
    void Update(float temp, float humidity, float pressure);
}

public interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

public class WeatherData : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public void RegisterObserver(IObserver o) => _observers.Add(o);
    public void RemoveObserver(IObserver o) => _observers.Remove(o);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        NotifyObservers();
    }
}

public class CurrentConditionsDisplay : IObserver
{
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        weatherData.RegisterObserver(this);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
}
```

Cách sử dụng

```csharp
WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);
weatherData.SetMeasurements(80, 65, 30.4f);
```
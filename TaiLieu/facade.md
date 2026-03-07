[Quay lại trang chính](../README.md)

## Facade Pattern

> Facade là mẫu thiết kế cấu trúc cung cấp giao diện thống nhất cho một tập hợp các giao diện trong subsystem. Facade định nghĩa giao diện cấp cao hơn làm cho subsystem dễ sử dụng hơn.

Hình minh họa cấu trúc UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/facade/structure.png" width="600"/> </p>

Facade che giấu sự phức tạp của subsystem và cung cấp giao diện đơn giản.

Ví dụ Home Theater trong Head First

```csharp
public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier on");
    public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
}

public class Tuner
{
    public void On() => Console.WriteLine("Tuner on");
}

public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD Player on");
    public void Play(string movie) => Console.WriteLine($"Playing {movie}");
}

public class HomeTheaterFacade
{
    private Amplifier _amp;
    private Tuner _tuner;
    private DVDPlayer _dvd;

    public HomeTheaterFacade(Amplifier amp, Tuner tuner, DVDPlayer dvd)
    {
        _amp = amp;
        _tuner = tuner;
        _dvd = dvd;
    }

    public void WatchMovie(string movie)
    {
        _amp.On();
        _amp.SetVolume(5);
        _tuner.On();
        _dvd.On();
        _dvd.Play(movie);
    }
}
```

Cách sử dụng

```csharp
Amplifier amp = new Amplifier();
Tuner tuner = new Tuner();
DVDPlayer dvd = new DVDPlayer();
HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd);
homeTheater.WatchMovie("Inception");
```
[Quay lại trang chính](../README.md)

## Adapter Pattern

> Adapter là mẫu thiết kế cấu trúc cho phép chuyển đổi giao diện của một lớp thành giao diện khác mà client mong đợi. Nó cho phép các lớp hoạt động cùng nhau mà bình thường không thể do giao diện không tương thích.

Hình minh họa cấu trúc UML

<img width="617" height="433" alt="image" src="https://github.com/user-attachments/assets/000f221b-4621-4cec-ac5d-0fa079f9c118" />

Adapter hoạt động bằng cách bọc một object adaptee bên trong một adapter có giao diện tương thích với client.

Ví dụ Ducks and Turkeys trong Head First

```csharp
public interface IDuck
{
    void Quack();
    void Fly();
}

public class MallardDuck : IDuck
{
    public void Quack() => Console.WriteLine("Quack");
    public void Fly() => Console.WriteLine("I'm flying");
}

public class Turkey
{
    public void Gobble() => Console.WriteLine("Gobble gobble");
    public void FlyShortDistance() => Console.WriteLine("I'm flying a short distance");
}

public class TurkeyAdapter : IDuck
{
    private Turkey _turkey;

    public TurkeyAdapter(Turkey turkey)
    {
        _turkey = turkey;
    }

    public void Quack() => _turkey.Gobble();

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            _turkey.FlyShortDistance();
        }
    }
}
```

Cách sử dụng

```csharp
IDuck duck = new TurkeyAdapter(new Turkey());
duck.Quack(); // Gobble gobble
duck.Fly(); // Fly short 5 times
```

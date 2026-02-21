[Quay lại trang chính](../README.md)

## 1. Strategy Pattern
 
> Strategy là mẫu thiết kế hành vi cho phép định nghĩa một họ thuật toán, đóng gói từng thuật toán và làm cho chúng có thể thay thế cho nhau tại runtime. Pattern này giúp loại bỏ việc kế thừa cứng nhắc và giảm các câu lệnh điều kiện phức tạp.

Hình minh họa cấu trúc UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/strategy/structure.png" width="600"/> </p>

Ý tưởng cốt lõi là tách phần thay đổi ra khỏi lớp chính và lập trình hướng tới interface thay vì implementation. Thay vì class tự quyết định hành vi, nó ủy quyền hành vi cho một strategy bên ngoài.

Ví dụ Duck trong Head First được viết lại bằng C#
```csharp
public interface IFlyBehavior
{
    void Fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void Fly() => Console.WriteLine("Tôi đang bay bằng cánh");
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly() => Console.WriteLine("Tôi không thể bay");
}

public class Duck
{
    private IFlyBehavior _flyBehavior;

    public Duck(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }
}
```

Khi nào nên dùng Strategy: khi có nhiều biến thể hành vi, khi muốn thay đổi hành vi tại runtime, khi muốn tuân thủ nguyên lý Open Closed và giảm phụ thuộc kế thừa.

[Quay lại trang chính](../README.md)
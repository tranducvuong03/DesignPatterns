[Quay lại trang chính](../README.md)

## 2. Decorator Pattern

> Decorator là mẫu thiết kế cấu trúc cho phép gắn thêm trách nhiệm cho một đối tượng một cách linh hoạt mà không cần sửa đổi class gốc. Đây là cách mở rộng chức năng theo hướng động thay vì tạo ra hàng loạt subclass.

Hình minh họa cấu trúc UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/decorator/structure.png" width="600"/> </p>

Decorator hoạt động bằng cách bọc một object bên trong một object khác có cùng interface. Nhờ đó có thể xếp chồng nhiều lớp decorator.

Ví dụ Starbuzz Coffee trong Head First

```csharp
public abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double Cost();
}

public class Espresso : Beverage
{
    public override string GetDescription() => "Espresso";
    public override double Cost() => 1.99;
}

public abstract class CondimentDecorator : Beverage
{
    protected Beverage _beverage;
}

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
        => _beverage.GetDescription() + ", Mocha";

    public override double Cost()
        => _beverage.Cost() + 0.20;
}
```
Cách sử dụng

```csharp
Beverage beverage = new Espresso();
beverage = new Mocha(beverage);

Console.WriteLine(beverage.GetDescription());
Console.WriteLine(beverage.Cost());
```
Khi nào nên dùng Decorator: khi cần thêm tính năng linh hoạt cho object, khi không muốn sửa class gốc, khi muốn tránh bùng nổ subclass.

[Quay lại trang chính](../README.md)

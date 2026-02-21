## Design Patterns Learning – Head First

Tài liệu tổng hợp quá trình học và triển khai các mẫu thiết kế từ sách Head First Design Patterns. Mục tiêu của repo này là hiểu bản chất thiết kế hướng đối tượng, giảm coupling, tăng khả năng mở rộng và tuân thủ các nguyên lý SOLID.

1. Strategy Pattern

Strategy là mẫu thiết kế hành vi cho phép định nghĩa một họ thuật toán, đóng gói từng thuật toán và làm cho chúng có thể thay thế cho nhau tại runtime. Pattern này giúp loại bỏ việc kế thừa cứng nhắc và giảm các câu lệnh điều kiện phức tạp.

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

2. Decorator Pattern

Decorator là mẫu thiết kế cấu trúc cho phép gắn thêm trách nhiệm cho một đối tượng một cách linh hoạt mà không cần sửa đổi class gốc. Đây là cách mở rộng chức năng theo hướng động thay vì tạo ra hàng loạt subclass.

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

Beverage beverage = new Espresso();
beverage = new Mocha(beverage);

Console.WriteLine(beverage.GetDescription());
Console.WriteLine(beverage.Cost());

Khi nào nên dùng Decorator: khi cần thêm tính năng linh hoạt cho object, khi không muốn sửa class gốc, khi muốn tránh bùng nổ subclass.

3. Factory Pattern

Factory là nhóm pattern khởi tạo dùng để đóng gói quá trình tạo object. Thay vì client tự khởi tạo bằng từ khóa new, việc tạo object được ủy quyền cho một factory.

Hình minh họa Factory Method UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/structure.png" width="600"/> </p>

Factory giúp giảm coupling giữa client và class cụ thể, đồng thời tuân thủ Dependency Inversion Principle.

Ví dụ Pizza Store trong Head First
```csharp
public abstract class Pizza
{
    public abstract void Prepare();
}

public class CheesePizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Chuẩn bị Cheese Pizza");
    }
}

public abstract class PizzaStore
{
    public Pizza OrderPizza()
    {
        var pizza = CreatePizza();
        pizza.Prepare();
        return pizza;
    }

    protected abstract Pizza CreatePizza();
}

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza()
    {
        return new CheesePizza();
    }
}
```
Khi nào nên dùng Factory: khi quá trình tạo object phức tạp, khi muốn tách logic khởi tạo khỏi business logic, khi cần thay đổi loại object mà không ảnh hưởng client.

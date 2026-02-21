[Quay lại trang chính](../README.md)

## 3. Factory Pattern

> Factory là nhóm pattern khởi tạo dùng để đóng gói quá trình tạo object. Thay vì client tự khởi tạo bằng từ khóa new, việc tạo object được ủy quyền cho một factory.

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

[Quay lại trang chính](../README.md)
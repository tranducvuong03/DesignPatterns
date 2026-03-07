[Quay lại trang chính](../README.md)

## Command Pattern

> Command là mẫu thiết kế hành vi đóng gói một yêu cầu thành một đối tượng, cho phép bạn tham số hóa client với các yêu cầu khác nhau, xếp hàng hoặc ghi log yêu cầu, và hỗ trợ các hoạt động có thể hoàn tác.

Hình minh họa cấu trúc UML

<p align="center"> <img src="https://refactoring.guru/images/patterns/diagrams/command/structure.png" width="600"/> </p>

Command cho phép tách biệt invoker khỏi receiver, và hỗ trợ undo.

Ví dụ Remote Control trong Head First

```csharp
public interface ICommand
{
    void Execute();
    void Undo();
}

public class Light
{
    public void On() => Console.WriteLine("Light is on");
    public void Off() => Console.WriteLine("Light is off");
}

public class LightOnCommand : ICommand
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.On();
    public void Undo() => _light.Off();
}

public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton() => _command.Execute();
    public void PressUndo() => _command.Undo();
}
```

Cách sử dụng

```csharp
Light light = new Light();
ICommand command = new LightOnCommand(light);
RemoteControl remote = new RemoteControl();
remote.SetCommand(command);
remote.PressButton(); // Light is on
remote.PressUndo(); // Light is off
```
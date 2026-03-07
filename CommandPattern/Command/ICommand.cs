namespace DesignPatterns.CommandPattern.Command
{
    public interface ICommand
    {
        public void Execute();
        public void Undo(); 
    }
}

//using DesignPatterns.CommandPattern.Command;
//using DesignPatterns.CommandPattern.Invoker;
//using DesignPatterns.CommandPattern.Receiver;

//var chef = new Chef();
//var waiter = new Waiter();

//Console.WriteLine("=== Bàn 1 gọi món ===");
//waiter.TakeOrder(new OrderFoodCommand(chef, "Bò lúc lắc"));
//waiter.TakeOrder(new OrderFoodCommand(chef, "Cơm chiên dương châu"));
//waiter.TakeOrder(new OrderDrinkCommand(chef, "Nước cam ép"));

//waiter.PlaceOrders();

//waiter.PrintHistory();

//Console.WriteLine("\n=== Khách huỷ đồ uống ===");
//waiter.CancelLastOrder();

//waiter.PrintHistory();

//[Client]
//   │  tạo: new OrderFoodCommand(chef, "Bò lúc lắc")
//   │         └── chef là Receiver nằm BÊN TRONG command
//   │
//   │  đưa command cho Waiter (Invoker)
//   ▼
//[Invoker - Waiter]
//   │  chỉ biết gọi: command.Execute()
//   │  KHÔNG biết bên trong làm gì
//   ▼
//[Command - OrderFoodCommand]
//   │  bên trong Execute() gọi: chef.CookDish("Bò lúc lắc")
//   ▼
//[Receiver - Chef]
//   └── thực sự nấu món ăn
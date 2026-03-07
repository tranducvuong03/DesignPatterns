namespace DesignPatterns.CommandPattern.Receiver
{
    public class Chef
    {
        public void CookDish(string dish)
        => Console.WriteLine($"Chef đang nấu: {dish}");

        public void CancelDish(string dish)
            => Console.WriteLine($"Chef huỷ món: {dish}");

        public void MakeDrink(string drink)
            => Console.WriteLine($"Chef đang pha: {drink}");

        public void CancelDrink(string drink)
            => Console.WriteLine($"Chef huỷ đồ uống: {drink}");
    }
}

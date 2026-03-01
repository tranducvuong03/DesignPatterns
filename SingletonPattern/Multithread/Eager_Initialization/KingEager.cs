namespace DesignPatterns.SingletonPattern.Multithread.Eager_Initialization
{
    public class KingEager
    {
        /*
            *Tại sao new KingEager() ở biến static?
                => Vì biến static được khởi tạo khi lớp được tải vào bộ nhớ, 
                nên việc tạo instance của KingEager tại đây đảm bảo rằng nó sẽ được
                tạo ra ngay lập tức khi lớp được sử dụng lần đầu tiên. Điều này giúp
                tránh các vấn đề liên quan đến đa luồng, vì instance đã được tạo sẵn 
                và không cần phải lo lắng về việc nhiều luồng cùng cố gắng tạo instance cùng lúc.
        */
        private static KingEager _instance = new KingEager();

        private KingEager()
        {
            Console.WriteLine("KingEager được tạo");
        }

        public static KingEager Instance => _instance;
    }
}

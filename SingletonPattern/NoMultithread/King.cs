namespace DesignPatterns.SingletonPattern.NoMultithread
{
    /*
     *Test nếu tạo nhiều thread:
        using DesignPatterns.SingletonPattern.NoMultithread;

        Parallel.For(0, 5, i =>
        {
            var king = King.Instance;
        });
    */

    public class King
    {
        private static King _instance;

        private King()
        {
            Console.WriteLine("King được tạo");
        }

        public static King Instance
        {
            get
            {
                if (_instance == null)
                {
                    Task.Delay(10).Wait();
                    _instance = new King();
                }

                return _instance;
            }
        }
    }
}

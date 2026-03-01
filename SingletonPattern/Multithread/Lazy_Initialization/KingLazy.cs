namespace DesignPatterns.SingletonPattern.Multithread.Lazy_Initialization
{
    // Cách 1: Sử dụng double-checked locking
    public class KingLazy
    {
        private static KingLazy _instance;
        private static object _lock = new object();

        private KingLazy()
        {
            Console.WriteLine("KingLazy được tạo");
        }

        public static KingLazy Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new KingLazy();
                        }
                    }
                }

                return _instance;
            }
        }
    }

    // Cách 2: Sử dụng Lazy<T>
    //public class KingLazy
    //{
    //    private static readonly Lazy<KingLazy> _instance =
    //        new Lazy<KingLazy>(() => new KingLazy());

    //    private KingLazy()
    //    {
    //        Console.WriteLine("King được tạo");
    //    }

    //    public static KingLazy Instance => _instance.Value;
    //}
}

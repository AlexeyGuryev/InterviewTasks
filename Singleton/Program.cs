using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LazySingleton.Instance.Name);
            Console.ReadKey();
        }
    }

    public class LazySingleton
    {
        private static Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
        private string _name;

        private LazySingleton()
        {
            _name = "Lazzy";
        }

        public static LazySingleton Instance
        {
            get { return _instance.Value; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}

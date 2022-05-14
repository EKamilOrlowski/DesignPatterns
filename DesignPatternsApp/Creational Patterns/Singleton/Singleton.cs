namespace DesignPatternsApp.Creational_Patterns.Singleton
{
    public class Singleton
    {
        private Singleton() { }

        private static readonly object _lock = new object();
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
            private set { }
        }

        public void RunBusinessLogic()
        {
        }
    }
}

namespace CaseAgenda.Singleton
{
    public class SingletonManager
    {
        private static SingletonManager instance;
        private int counter;

        private SingletonManager()
        {
            // Private constructor to prevent instantiation outside the class
            counter = 0;
        }

        public static SingletonManager Instance
        {
            get
            {
                // Lazy initialization
                if (instance == null)
                {
                    instance = new SingletonManager();
                }
                return instance;
            }
        }

        public int GetCounter()
        {
            return counter;
        }

        public void IncrementCounter()
        {
            counter++;
        }
    }
}

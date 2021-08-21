namespace Core.SingletonPattern
{
    // The keyword "sealed" can guard this scenario.
    // public class NestedDerived : Singleton { }
    public sealed class Singleton
    {
        /*
         * We are using volatile to ensure
         * that assignment to the instance variable finishes
         * before it's accessed.
        */
        private static volatile Singleton Instance;
        private static readonly object lockObject = new();

        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                // First Check
                if (Instance == null)
                {
                    lock (lockObject)
                    {
                        // Second(Double) Check
                        if (Instance == null)
                            // Lazy initialization
                            Instance = new Singleton();
                    }
                }
                return Instance;
            }
        }
    }
}

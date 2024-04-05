namespace _11_1_Singleton
{
    /// <summary>
    /// Singleton design pattern
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// The singleton static instance
        /// </summary>
        private static Singleton? instance = null;

        /// <summary>
        /// Private default constructor can only be call by Singleton
        /// </summary>
        private Singleton() { }
   
        /// <summary>
        /// Returns the previous instance or if no previous instance a new one.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}

namespace _11_1_Singleton
{
    /// <summary>
    /// Demonstrates the Singleton design pattern
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            /* The Singleton Design Pattern is a creational design pattern that ensures 
             * a class has only one instance, providing a global point of access to it. 
             * It can be useful in situations where you want to limit the number of 
             * instances of a class, or when you need a single object to coordinate 
             * actions across the system. */

            // Some other useful forms of the Singleton design pattern can be found here:
            // https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/

            Singleton singleton = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton == singleton2)
            {
                Console.WriteLine("These references are identical.");
            }
        }
    }
}

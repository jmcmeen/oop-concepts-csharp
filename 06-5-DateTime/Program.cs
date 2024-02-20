namespace _06_5_DateTime
{
    /// <summary>
    /// Demonstrates very basic DateTime usage
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            List<DateTime> list = new List<DateTime>();

            DateTime date1 = new DateTime();
            DateTime date2 = DateTime.Now;
            DateTime date3 = DateTime.UtcNow;
            DateTime date4 = DateTime.Today;

            list.Add(date1);
            list.Add(date2);
            list.Add(date3);
            list.Add(date4);

            foreach(DateTime dt in list)
            {
                Console.WriteLine(dt);
            }
        }
    }
}
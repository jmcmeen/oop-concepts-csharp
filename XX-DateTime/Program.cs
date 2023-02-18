namespace XX_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> list = new List<DateTime>();

            DateTime date1 = DateTime.Now;
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
namespace _03_7_CopyConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.City = "Elizabethton";
            address.Street = "111 E E St";


            Person p1 = new Person(0, "John", address);
            Person p2 = new Person(1, "Britney", address);
            Person p3 = new Person(p2);

            Console.WriteLine();

            p2.Address = new Address();

            p2.Address.City = "Johnson City";
            p2.Address.Street = "101 Locust St";

            p3.Address.City = "Bristol";
            p3.Address.Street = "123 Main St";

            Console.WriteLine();
        }
    }
}

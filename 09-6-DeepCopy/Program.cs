namespace _11_5_DeepCopy
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Create a Person and its Address
            Person personOne = new Person
            {
                Name = "Zaphod Beeblebrox",
                Address = new Address
                {
                    Street = "123 New Street",
                    City = "Miami",
                    State = "Florida",
                    Zip = "33101 "
                }
            };

            Console.WriteLine($"personOne -> {personOne}");

            //Now we clone this Person object
            Person personTwo = (Person)personOne.Clone();

            Console.WriteLine($"personTwo -> {personTwo}");

            //But the story isn't over
            Console.WriteLine("Oh do tell...");

            //Since .Clone() in Person implemented a deep copy of Address, both of these Person objects have different
            //Address references, meaning they have their own Address memory. In some cases, this is okay, in others,
            //a Shallow Copy may be preferred for speed of copy. Let's see what happens to both objects when I make
            //a change to the first one only.
            personOne.Address.Street = "456 Some New St";

            //Only personOne's Address changes, because there are two address objects, one for each Person
            Console.WriteLine($"personOne -> {personOne}");
            Console.WriteLine($"personTwo -> {personTwo}");
        }
    }
}
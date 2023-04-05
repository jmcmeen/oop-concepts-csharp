namespace _11_4_ShallowCopy
{
    internal class Program
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

            //Since .Clone() in Person implemented a shallow copy of Address, both of these Person objects have the same
            //Address reference, meaning they point to the same Address object. In some cases, this is okay, in others,
            //a Deep Copy may be needed so that each Person object can have it's own Address object reference. Let's see
            //what happens to both objects when I make a change to the first one only.
            personOne.Address.Street = "456 Some New St";

            //"Both" Person object's Addresses change, because there aren't two address objects, the shallow copy just copied a reference
            Console.WriteLine($"personOne -> {personOne}");
            Console.WriteLine($"personTwo -> {personTwo}");
        }
    }
}
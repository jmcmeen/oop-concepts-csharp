namespace _04_Inheritance
{
    internal class Animal
    {
        protected String Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I have no voice.");
        }
    }
}

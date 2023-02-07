namespace _04_AbstractClasses
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Woof!");
        }
    }
}

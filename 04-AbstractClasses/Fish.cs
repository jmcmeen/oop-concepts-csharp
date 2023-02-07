namespace _04_AbstractClasses
{
    internal class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.Write($"My name is {Name} and I'm a fish bro, I don't make sound.");
        }
    }
}

namespace _04_Inheritance
{
    internal class Elephant : Animal
    {
        public Elephant(string name) : base(name){}

        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Toot Toot!");
        }
    }
}

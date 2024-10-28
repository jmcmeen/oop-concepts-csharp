namespace _05_2_AbstractClasses
{
    internal class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawr!");
        }
    }
}

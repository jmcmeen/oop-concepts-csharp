namespace _04_AbstractClasses
{
    internal class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}

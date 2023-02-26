namespace _04_AbstractClasses
{
    internal class Donkey : Animal
    {
        public Donkey(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}

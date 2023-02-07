namespace _04_AbstractClasses
{
    internal abstract class Animal
    {
        protected String Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }
}

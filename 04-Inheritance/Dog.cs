using System.Xml.Linq;

namespace _04_Inheritance
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

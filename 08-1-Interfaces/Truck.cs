namespace _08_1_Interfaces
{
    internal class Truck : Vehicle, IMakeSound
    {
        public override void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            Console.WriteLine("Vrooom Vroom");
        }
    }
}

﻿namespace _08_1_Interfaces
{
    internal class Duck : IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Quack!");
        }
    }
}

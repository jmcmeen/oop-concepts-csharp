﻿namespace XX_Physics
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Space s = new Space();
            Random r = new Random();

            for (int i = 0; i < 2; i++)
            {
                s.AddParticle(r.Next(), r.Next(), r.Next(), r.Next());
            }

            for (int i = 0; i < s.particles.Count; i++)
            {
                for (int j = i + 1; j < s.particles.Count; j++)
                {
                    Console.WriteLine($"{s.particles[i]} - {s.particles[j]} - {s.particles[i].CalculateForceMagnitude(s.particles[j])}");
                }
            }
        }
    }
}
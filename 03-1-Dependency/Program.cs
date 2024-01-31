namespace _03_1_Dependency
{
    internal class Program
    {
        static void Main()
        {
            //Two objects or classes are considered to be Dependent if one utilizes the other
            //Here our program class has a dependency with the Random class because I am using
            //an object of the Random class to return a Random number.

            //The dependency relationship is often called a "uses a" relationship
            //Because we say here "The Program class uses a Random object to..."
            //We would say the same thing of Console in this context.
            Random r = new Random();
            Console.WriteLine(r.Next(1, 101));
        }
    }
}

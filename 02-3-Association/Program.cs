namespace _02_3_Association
{
    /// <summary>
    /// A brief explanation of the object relationship Association
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Two objects or classes are considered to be Associated if one utilizes the other
            //Here our program class has an Association with the Random class because I am using
            //Random class to return a Random number.

            //The Association relationship is often called a "uses a" relationship
            //Because we say here "The Program class uses a Random object to..."
            Random r = new Random();
            Console.WriteLine(r.Next(1, 101));

            //Association can also mean that one object encapsulates an object of another type
            //Here the Course class "has a" DateTime called StartDate and "has a" DateTime called EndDate
            Course c = new Course();

            c.StartDate = DateTime.Now;
            c.EndDate = DateTime.Today.AddDays(1);

            //This "has a" relationship is an Association, but we can describe this relationship
            //in a little more detail with Composition and Aggregation relationships
            //which are described in the next module
        }
    }
}
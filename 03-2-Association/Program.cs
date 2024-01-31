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
            //Two classes are considered to be Associated if one instance owns an instance(s) of the other,
            //which is to say an object encapsulates an object(s) of another type. 
            //The Association relationship is often called a "has a" relationship

            //Here the Course class "has a" DateTime called StartDate and "has a" DateTime called EndDate
            Course c = new Course();

            c.StartDate = DateTime.Now;
            c.EndDate = DateTime.Today.AddDays(1);

            //This "has a" relationship is an Association, but we can describe this relationship
            //in a little more detail with Composition and Aggregation relationships
            //which are described in the next examples.
        }
    }
}
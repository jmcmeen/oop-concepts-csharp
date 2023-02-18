namespace XX_ObjectsVSStaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static helper class example
            Console.WriteLine("Using static methods from the OhmsLawUtility static helper class");
            Console.WriteLine("\tOhms = " + OhmsLawUtility.GetOhms(.005, 9));
            Console.WriteLine("\tVolts = " + OhmsLawUtility.GetVolts(.005, 1800));
            Console.WriteLine("\tAmps = " + OhmsLawUtility.GetAmps(1800, 9));

            //Object-oriented Ohms Law demonstration
            Console.WriteLine("Using objects to represent Ohm's law values");
            Ohm o = new Ohm(.005, 9);
            Console.WriteLine("\tOhms = " + o.GetValue());

            Volt v = new Volt(.005, 1800);
            Console.WriteLine("\tVolts = " + v.GetValue());

            Amp a = new Amp(1800, 9);
            Console.WriteLine("\tAmps = " + a.GetValue());
        }
    }
}
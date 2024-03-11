namespace SampleClasses
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override string ToString()
        { 
            return $"Radius: {Radius}, Area: {Area}";
        }
    }
}

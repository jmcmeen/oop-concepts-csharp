namespace _03_4_Composition
{
    /// <summary>
    /// Models a car
    /// </summary>
    internal class Car
    {
        //private Engine field
        private Engine engine;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car()
        {
            //Here the car constructor creates a reference to an Engine obect
            engine = new Engine();
        }

        /// <summary>
        /// Sets the isOn variable to true
        /// </summary>
        public void EngineOn()
        {
            engine.isOn = true;
        }

        /// <summary>
        /// Sets the isOn variable to false
        /// </summary>
        public void EngineOff()
        {
            engine.isOn = false;
        }

        /// <summary>
        /// Converts a car object to a string
        /// </summary>
        /// <returns>string representation of car</returns>
        public override string ToString()
        {
            return "The car is" + (engine.isOn ? " on" : " off");
        }
    }
}

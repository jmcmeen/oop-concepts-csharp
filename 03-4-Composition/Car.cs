namespace _03_4_Composition
{
    internal class Car
    {
        //private Engine field
        private Engine engine;

        //Here the car constructor creates a reference to an Engine obect
        public Car()
        {
            engine = new Engine();
        }

        //turn the engine on
        public void EngineOn()
        {
            engine.isOn = true;
        }

        //turn the engine off
        public void EngineOff()
        {
            engine.isOn = false;
        }

        //convert Car to string
        public override string ToString()
        {
            return "The car is" + (engine.isOn ? " on" : " off");
        }
    }
}

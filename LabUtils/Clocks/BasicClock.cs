namespace SampleClasses.Clocks
{
    /// <summary>
    /// Models an Earthling's clock
    /// </summary>
    public class BasicClock
    {
        /// <summary>
        /// Seconds value
        /// </summary>
        private int Seconds { get; set; }

        /// <summary>
        /// Minutes value
        /// </summary>
        private int Minutes { get; set; }

        /// <summary>
        /// Hours value
        /// </summary>
        private int Hours { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasicClock()
        {
            Seconds = 0;
            Minutes = 0;
            Hours = 0;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="seconds"></param>
        /// <param name="minutes"></param>
        /// <param name="hours"></param>
        public BasicClock(int seconds, int minutes, int hours)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        /// <summary>
        /// Copy constructor 
        /// </summary>
        /// <param name="other"></param>
        public BasicClock(BasicClock other)
        {
            Seconds = other.Seconds;
            Minutes = other.Minutes;
            Hours = other.Hours;
        }

        /// <summary>
        /// Decrements the seconds
        /// </summary>
        /// 
        public void DecrementSeconds()
        {
            if (Seconds == 0)
            {
                Seconds = 59;

                if (Minutes == 0)
                {
                    Minutes = 59;
                    Hours -= 1;
                }
                else
                {
                    Minutes -= 1;
                }
            }
            else
            {
                Seconds--;
            }
        }

        /// <summary>
        /// Increments the seconds
        /// </summary>
        public void IncrementSeconds()
        {
            if (Seconds == 59)
            {
                Seconds = 0;

                if (Minutes == 59)
                {
                    Minutes = 0;
                    Hours += 1;
                }
                else
                {
                    Minutes += 1;
                }
            }
            else
            {
                Seconds++;
            }
        }

        /// <summary>
        /// Overrides base class ToString
        /// </summary>
        /// <returns>a string representation of the watch instance</returns>
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
}

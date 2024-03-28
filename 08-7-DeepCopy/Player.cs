namespace _8_7_DeepCopy
{
    internal class Player : ICloneable
    {
        public string? Username { get; set; }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //create a new Player, String = will make a new string
            return new Player { Username = Username };
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"Player: {{ Username = {Username} }}";
        }
    }
}

namespace _04_1_Inheritance
{
    /// <summary>
    /// Models a Fish derived frm Animal
    /// </summary>
    internal class Fish : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Fish's name</param>
        public Fish(string name) : base(name)
        {
        }
    }
}

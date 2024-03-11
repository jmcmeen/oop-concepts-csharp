namespace _04_6_CustomExceptions
{
    /// <summary>
    /// Exception for invalid banking amount
    /// </summary>
    internal class InvalidAmountException : Exception
    {
        private const string MESSAGE = "Invalid amount for Transaction!";
        public InvalidAmountException() : base(MESSAGE) { }
    }
}

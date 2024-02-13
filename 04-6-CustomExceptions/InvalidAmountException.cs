namespace _04_CustomExceptions
{
    internal class InvalidAmountException : Exception
    {
        private const string MESSAGE = "Invalid amount for Transaction!";
        public InvalidAmountException() : base(MESSAGE) { }
    }
}

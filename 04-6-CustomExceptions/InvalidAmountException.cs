namespace _04_CustomExceptions
{
    internal class InvalidAmountException : Exception
    {
        private const string MESSAGE = "Insufficient Funds for Transaction!";
        public InvalidAmountException() : base(MESSAGE) { }
    }
}

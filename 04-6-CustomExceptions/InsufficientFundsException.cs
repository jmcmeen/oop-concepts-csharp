namespace _04_CustomExceptions
{
    internal class InsufficientFundsException : Exception
    {
        private const string MESSAGE = "Insufficient Funds for Transaction!";
        public InsufficientFundsException() : base(MESSAGE) { }
    }
}

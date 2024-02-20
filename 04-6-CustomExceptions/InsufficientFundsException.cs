namespace _04_6_CustomExceptions
{
    /// <summary>
    /// Exception for insufficient funds
    /// </summary>
    internal class InsufficientFundsException : Exception
    {
        private const string DEFAULT_MSG = "Insufficient Funds for Transaction!";

        /// <summary>
        /// Default constructor
        /// </summary>
        public InsufficientFundsException() : base(DEFAULT_MSG) { }
    }
}

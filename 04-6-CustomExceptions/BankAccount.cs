namespace _04_6_CustomExceptions
{
    /// <summary>
    /// Models a bank account
    /// </summary>
    internal class BankAccount
    {
        //private fields 
        private decimal _balance;

        //public auto-implemented 
        public int Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Adds a positive amount to the balance
        /// </summary>
        /// <param name="amount">the amount to deposit</param>
        /// <exception cref="InvalidAmountException"></exception>
        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new InvalidAmountException();
            }

            _balance += amount;
        }

        /// <summary>
        /// Subtracts a positive amount from the balance
        /// </summary>
        /// <param name="amount">the amount to withdraw</param>
        /// <exception cref="InsufficientFundsException"></exception>
        /// <exception cref="InvalidAmountException"></exception>
        public void Withdraw(decimal amount)
        {
            if(amount > _balance)
            {
                throw new InsufficientFundsException();
            } 
            if(amount <= 0)
            {
                throw new InvalidAmountException();
            }

            _balance -= amount;
        }

        /// <summary>
        /// Converts bank account to string
        /// </summary>
        /// <returns>string representation of BankAccount</returns>
        public override string ToString()
        {
            return $"{Name } {_balance}";

        }
    }
}

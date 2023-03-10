namespace _04_CustomExceptions
{
    internal class BankAccount
    {
        private decimal _balance;
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal Balance { get { return _balance; } }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new InvalidAmountException();
            }

            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                throw new InsufficientFundsException();
            } 
            if(amount <= 0)
            {
                throw new InvalidAmountException();
            }

            _balance -= amount;
        }

        public override string ToString()
        {
            return $"{Name } {Balance}";

        }
    }
}

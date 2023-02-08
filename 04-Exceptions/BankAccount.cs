namespace _04_Exceptions
{
    internal class BankAccount
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if(amount > Balance)
            {
                
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}

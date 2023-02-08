using System.Numerics;

namespace _04_CustomExceptions
{
    internal class BankAccount
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {

            
        }

        public void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                throw new InsufficientFundsException();
            } 
            if(amount <= 0)
            {
                throw new Exception();
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"{Name } {Balance}";

        }
    }
}

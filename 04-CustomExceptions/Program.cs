namespace _04_CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount { 
                Id = 1,
                Name= "John McMeen",
                Balance = 500 
            };

            try
            {
                b.Withdraw(600);
                b.Withdraw(-100);
                b.Deposit(1000000);
            }
            catch (InvalidAmountException ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            catch(InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(b);
        }
    }
}
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
            }
            catch (InsufficientFundsException ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            catch(InvalidAmountException ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            

            Console.WriteLine(b);
        }
    }
}
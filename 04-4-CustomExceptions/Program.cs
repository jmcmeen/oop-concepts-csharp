﻿namespace _04_7_CustomExceptions
{
    /// <summary>
    /// Program to demonstrate 
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            BankAccount b = new BankAccount
            {
                Id = 1,
                Name = "Burf Snerfle",
            };

            b.Deposit(100.00m);

            try
            {
                b.Withdraw(600.00m);
                b.Withdraw(-100.00m);
                b.Deposit(1000000.00m);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(b);
        }
    }
}
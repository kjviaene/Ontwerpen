using System;
using Banking.Models;

namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-4567890-02");
            Console.WriteLine($"Balans: {account.Balance}");
            account.Deposit(200);
            Console.WriteLine($"Balans: {account.Balance}");
            account.Withdraw(100);
            Console.WriteLine($"Balans: {account.Balance}");
            Console.ReadKey();


        }
    }
}

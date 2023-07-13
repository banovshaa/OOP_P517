using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}. New balance:{Balance}");
    }
    public void Withdraw(double amount)
    {
        if (amount<=Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw: {amount}. New balance:{Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
 
    }

    public BankAccount(int accountNumber)
    {
        this.AccountNumber = accountNumber;
        this.Balance = 0;
    }
}

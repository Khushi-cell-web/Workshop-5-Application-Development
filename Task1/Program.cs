using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a BankAccount object
        BankAccount myAccount = new BankAccount("ACC12345", 1000);

        // Display account number
        Console.WriteLine($"Account Number: {myAccount.AccountNumber}");

        // Deposit money
        myAccount.Deposit(500);

        // Withdraw money
        myAccount.Withdraw(300);

        // Print remaining balance
        Console.WriteLine($"Remaining Balance: {myAccount.Balance:C}");
    }
}

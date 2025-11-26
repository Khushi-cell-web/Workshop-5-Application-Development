using System;

public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Constructor to set account number and initial balance
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance; // Using property to enforce validation
    }

    // Public property: AccountNumber (read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property: Balance (private set, only allows positive values)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                throw new ArgumentException("Balance must be greater than 0.");
            }
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. Remaining balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Check balance and try again.");
        }
    }
}

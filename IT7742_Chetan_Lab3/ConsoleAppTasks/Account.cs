using System;

abstract class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public abstract double CalculateInterest();
    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account: " + AccountNumber + "  Balance: " + Balance);
    }
}


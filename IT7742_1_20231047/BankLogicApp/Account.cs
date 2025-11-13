namespace BankLogicApp;

public abstract class Account
{
    private int _accountID;
    private double _balance;
    private double _interestRate;
    private double _overdraftLimit;
    private double _failedFee;
    private string _lastMessage = "";

    protected Account(int id, double opening, double rate, double overdraft, double failedFee)
    {
        _accountID = id;
        _balance = opening;
        _interestRate = rate;
        _overdraftLimit = overdraft;
        _failedFee = failedFee;
    }

    public int GetAccountID() => _accountID;
    public double GetBalance() => _balance;
    public string LastMessage() => _lastMessage;

    protected double Rate() => _interestRate;
    protected double Overdraft() => _overdraftLimit;
    protected double FailedFee() => _failedFee;

    protected void SetBalance(double v) => _balance = v;
    protected void SetLastMessage(string msg) => _lastMessage = msg;

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            SetLastMessage($"Deposit ignored: {amount}");
            return;
        }
        _balance += amount;
        SetLastMessage($"Deposit: {amount:0.00}; Balance: {_balance:0.00}");
    }

    public void Withdraw(double amount, bool isStaff)
    {
        if (amount <= 0)
        {
            SetLastMessage($"Withdraw ignored: {amount}");
            return;
        }

        if (!CanWithdraw(amount))
        {
            var fee = isStaff ? FailedFee() * 0.5 : FailedFee();
            if (fee > 0)
            {
                _balance -= fee;
                SetLastMessage($"Withdrawal Failed: {amount:0.00}; Fee: {fee:0.00}; Balance: {_balance:0.00}");
            }
            else
            {
                SetLastMessage($"Withdrawal Failed: {amount:0.00}; Balance: {_balance:0.00}");
            }
            return;
        }

        _balance -= amount;
        SetLastMessage($"Withdraw: {amount:0.00}; Balance: {_balance:0.00}");
    }

    protected virtual bool CanWithdraw(double amount)
    {
        return GetBalance() - amount >= -Overdraft();
    }

    public abstract void CalculateInterest();

    public string AccountInfo()
    {
        return $"{GetType().Name} {GetAccountID()}; " +
               $"IR {Rate():0.##}%;" +
               $" OD {Overdraft():0.##}; Fee {FailedFee():0.##}; " +
               $"Balance {GetBalance():0.00}; " +
               $"Last: {LastMessage()}";
    }
}

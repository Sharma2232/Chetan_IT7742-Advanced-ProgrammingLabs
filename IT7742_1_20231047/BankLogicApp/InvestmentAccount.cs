namespace BankLogicApp;

public class InvestmentAccount : Account
{
    public InvestmentAccount(int id, double opening, double rate, double failedFee)
        : base(id, opening, rate, 0, failedFee) { }

    public override void CalculateInterest()
    {
        var interest = GetBalance() * (Rate() / 100.0);
        SetBalance(GetBalance() + interest);
        SetLastMessage($"Interest Added: {interest:0.00}; Balance: {GetBalance():0.00}");
    }

    protected override bool CanWithdraw(double amount)
    {
        return GetBalance() - amount >= 0;
    }
}

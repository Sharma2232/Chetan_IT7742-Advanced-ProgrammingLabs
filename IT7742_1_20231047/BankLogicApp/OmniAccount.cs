namespace BankLogicApp;

public class OmniAccount : Account
{
    public OmniAccount(int id, double opening, double rate, double overdraft, double failedFee)
        : base(id, opening, rate, overdraft, failedFee) { }

    public override void CalculateInterest()
    {
        double eligible = GetBalance() > 1000 ? GetBalance() - 1000 : 0;
        double interest = eligible * (Rate() / 100.0);
        SetBalance(GetBalance() + interest);
        SetLastMessage($"Interest Added: {interest:0.00}; Balance: {GetBalance():0.00}");
    }
}

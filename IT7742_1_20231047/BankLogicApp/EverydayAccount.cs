namespace BankLogicApp;

public class EverydayAccount : Account
{
    public EverydayAccount(int id, double opening)
        : base(id, opening, 0, 0, 0) { }

    public override void CalculateInterest()
    {
        // No interest for this type
        Deposit(0);
    }
}

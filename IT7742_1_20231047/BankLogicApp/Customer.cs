namespace BankLogicApp;

public class Customer
{
    private int _customerNumber;
    private string _name;
    private string _contact;
    private bool _isStaff;

    public Customer(int id, string name, string contact, bool staff = false)
    {
        _customerNumber = id;
        _name = name;
        _contact = contact;
        _isStaff = staff;
    }

    public bool IsStaff() => _isStaff;
    public string GetName() => _name;
}

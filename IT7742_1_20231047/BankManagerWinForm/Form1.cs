using System;
using System.Windows.Forms;
using BankLogicApp;  // reference your logic project

namespace BankManagerWinForm
{
    public partial class Form1 : Form
    {
        private readonly Customer _cust;
        private readonly EverydayAccount _every;
        private readonly InvestmentAccount _invest;
        private readonly OmniAccount _omni;

        public Form1()
        {
            InitializeComponent();

            // Sample customer data
            _cust = new Customer(101, "Arun Patel", "arun@bank.co.nz", staff: true);

            // Initialize accounts
            _every = new EverydayAccount(11, 400);
            _invest = new InvestmentAccount(22, 620, rate: 4.0, failedFee: 10);
            _omni = new OmniAccount(33, 1320.43, rate: 4.0, overdraft: 100, failedFee: 10);

            cboAccounts.Items.AddRange(new object[]
            {
                "Everyday Account (11)",
                "Investment Account (22)",
                "Omni Account (33)"
            });
            cboAccounts.SelectedIndex = 0;
        }

        private Account Current()
        {
            return cboAccounts.SelectedIndex switch
            {
                0 => _every,
                1 => _invest,
                _ => _omni
            };
        }

        private double ParseAmount()
        {
            if (!double.TryParse(txtAmount.Text, out var amt))
            {
                lstDisplay.Items.Add("Please enter a valid amount.");
                return 0;
            }
            return amt;
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            var acc = Current();
            var amt = ParseAmount();
            if (amt <= 0) return;

            acc.Deposit(amt);
            lstDisplay.Items.Add(acc.LastMessage());
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            var acc = Current();
            var amt = ParseAmount();
            if (amt <= 0) return;

            acc.Withdraw(amt, _cust.IsStaff());
            lstDisplay.Items.Add(acc.LastMessage());
        }

        private void BtnInterest_Click(object sender, EventArgs e)
        {
            var acc = Current();
            acc.CalculateInterest();
            lstDisplay.Items.Add(acc.LastMessage());
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            var acc = Current();
            lstDisplay.Items.Add(acc.AccountInfo());
        }
    }
}

using System.Windows.Forms;
using System.Drawing;

namespace BankManagerWinForm
{
    partial class Form1
    {
        private ComboBox cboAccounts;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnInterest;
        private Button btnInfo;
        private ListBox lstDisplay;
        private Label lblAmount;

        private void InitializeComponent()
        {
            cboAccounts = new ComboBox();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnInterest = new Button();
            btnInfo = new Button();
            lstDisplay = new ListBox();
            lblAmount = new Label();

            SuspendLayout();

            // ComboBox
            cboAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAccounts.Location = new Point(25, 25);
            cboAccounts.Name = "cboAccounts";
            cboAccounts.Size = new Size(200, 28);

            // TextBox
            txtAmount.Location = new Point(250, 25);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 27);

            // Label
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(250, 5);
            lblAmount.Text = "Amount:";

            // Deposit button
            btnDeposit.Location = new Point(25, 70);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(100, 30);
            btnDeposit.Text = "Deposit";
            btnDeposit.Click += BtnDeposit_Click;

            // Withdraw button
            btnWithdraw.Location = new Point(140, 70);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(100, 30);
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.Click += BtnWithdraw_Click;

            // Interest button
            btnInterest.Location = new Point(255, 70);
            btnInterest.Name = "btnInterest";
            btnInterest.Size = new Size(100, 30);
            btnInterest.Text = "Add Interest";
            btnInterest.Click += BtnInterest_Click;

            // Info button
            btnInfo.Location = new Point(370, 70);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(100, 30);
            btnInfo.Text = "Info";
            btnInfo.Click += BtnInfo_Click;

            // ListBox
            lstDisplay.Location = new Point(25, 120);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(450, 180);

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 330);
            Controls.Add(cboAccounts);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnInterest);
            Controls.Add(btnInfo);
            Controls.Add(lstDisplay);
            Name = "Form1";
            Text = "Bank Manager App";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

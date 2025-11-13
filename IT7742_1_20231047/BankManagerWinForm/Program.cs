using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BankManagerWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // This sets up default WinForms settings (fonts, DPI, etc.)
            ApplicationConfiguration.Initialize();

            // Launch the main form (Form1)
            Application.Run(new Form1());
        }
    }
}

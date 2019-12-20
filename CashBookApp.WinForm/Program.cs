using CashBookApp.WinForm.UI;
using CashBookApp.WinForm.UI.Sales;
using CashBookApp.WinForm.UI.Setting;
using CashBookApp.WinForm.UI.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBookApp.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("tr-TR");
            cultureInfo.NumberFormat.CurrencySymbol = "₺";



            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin);


            if (frmLogin.IsLoggedin)
            {
                Application.Run(new FrmMain());
            }
            
        }
    }
}

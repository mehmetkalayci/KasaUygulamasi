using AutoUpdaterDotNET;
using CashBookApp.WinForm.Helper;
using CashBookApp.WinForm.UI.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBookApp.WinForm.UI
{
    public partial class FrmMain : BaseForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void TlCustomers_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Client.FrmCustomerList>();
        }

        private void TlSearchStock_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Stock.FrmStockList>();
        }

        private void TlStocks_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Stock.FrmStockAdd>();
        }

        private void TlLock_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (!frmLogin.IsLoggedin)
            {
                Application.Exit();
            }
        }

        private void TlAbout_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Setting.FrmAbout>();
        }

        private void TlUserSettings_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Setting.FrmLoginSettings>();
        }

        private void TlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TlAddExpense_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<CashBook.FrmPaymentAdd>();
        }

        private void TlCashBook_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<CashBook.FrmPaymentList>();
        }

        private void TlSales_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Sales.FrmSalesAdd>();
        }

        private void TlSalesList_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Sales.FrmSalesList>();
        }


        private void TlBackupRestore_Click(object sender, EventArgs e)
        {
            string backupFile = Application.StartupPath + "\\Backup.exe";
            bool isBackupAvailable = File.Exists(backupFile);
            if (isBackupAvailable)
            {
                if (MessageBox.Show("Yedekleme/geri yükleme işlemini başlatmak için program kapatılsın mı?", "Yedekle/Geri Yükle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Process.Start(backupFile);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Yedekleme / geri yükleme dosyası silinmiş ya da hatalı/eksik kurulum!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            AutoUpdater.Start(Properties.Settings.Default.UpdateURL);
        }
    }
}

using CashBookApp.WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBookApp.WinForm.UI.Setting
{
    public partial class FrmLoginSettings : BaseForm
    {
        public FrmLoginSettings()
        {
            InitializeComponent();
        }

        CashBookEntities db = new CashBookEntities();
        string oldpass = "";


        private void FrmLoginSettings_Load(object sender, EventArgs e)
        {
            var user = db.User.Where(q => q.UserID == 1).FirstOrDefault();

            txtUsername.Text = user.UserName;
            oldpass = user.Password;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = db.User.Where(q => q.UserID == 1).FirstOrDefault();

            user.UserName = txtUsername.Text;

            if (txtNewPassword.Text.Trim().Length > 0)
            {
                user.Password = txtNewPassword.Text;
            }


            if (oldpass == txtOldPassword.Text)
            {
                int num = db.SaveChanges();
                if (num >= 1)
                {
                    Helper.MessageHelper.InfoMessage("Bilgiler güncellendi!");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Eski şifre hatalı!");
            }
        }
    }
}

using CashBookApp.WinForm.Helper;
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

namespace CashBookApp.WinForm.UI.Client
{
    public partial class FrmCustomerEdit : BaseForm
    {
        public FrmCustomerEdit(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        int customerID = 0;

        CashBookEntities db = new CashBookEntities();

        Customer customer4Update = null;


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtFullName.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Ad soyad girin!");
                    return;
                }
                if (String.IsNullOrEmpty(txtPhone.Text.Trim()))
                {
                    DialogResult result = MessageHelper.AskMessage("Telefon bilgisi olmadan kaydedilsin mi?");
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }



                customer4Update.FullName = txtFullName.Text;
                customer4Update.Phone = txtPhone.Text;
                if (dtCreatedAt.Checked)
                {
                    customer4Update.CreatedAt = dtCreatedAt.Value;
                }


                if (db.Entry(customer4Update).State == System.Data.Entity.EntityState.Unchanged)
                {
                    DialogResult result = MessageHelper.AskMessage("Değişiklik yapmadınız, güncelleme penceresini kapatmak ister misiniz?");
                    if (result == DialogResult.Yes)
                    {
                        Close();
                    }
                }

                int i = db.SaveChanges();
                if (i > 0)
                {

                    /*
                     SATIŞ EKRANINDAKİ MÜŞTERİLERİ GÜNCELLE
                     */

                    FrmCustomerList frmCustomerList = (FrmCustomerList)Application.OpenForms["FrmCustomerList"];
                    if (frmCustomerList != null)
                    {
                        frmCustomerList.LoadCustomers();
                    }
                    MessageHelper.InfoMessage("Müşteri güncellendi!");
                }
                else
                {
                    if (db.Entry(customer4Update).State != System.Data.Entity.EntityState.Unchanged)
                    {
                        MessageHelper.InfoMessage("Güncelleme başarısız!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }

        }

        private void FrmCustomerEdit_Load(object sender, EventArgs e)
        {
            customer4Update = db.Customer.Where(q => q.CustomerID == this.customerID && q.IsDeleted == false).FirstOrDefault();

            if (customer4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı müşteri bulunamadı!");
                return;
            }

            dtCreatedAt.Value = customer4Update.CreatedAt;
            txtFullName.Text = customer4Update.FullName;
            txtPhone.Text = customer4Update.Phone;
        }
    }
}

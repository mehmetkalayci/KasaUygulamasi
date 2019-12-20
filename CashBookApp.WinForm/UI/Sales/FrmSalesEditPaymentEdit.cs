using CashBookApp.WinForm.Helper;
using CashBookApp.WinForm.Model;
using CashBookApp.WinForm.UI.CashBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBookApp.WinForm.UI.Sales
{
    public partial class FrmSalesEditPaymentEdit : BaseForm
    {
        public FrmSalesEditPaymentEdit(int paymentID)
        {
            InitializeComponent();
            this.paymentID = paymentID;
        }

        int paymentID = 0;


        CashBookEntities db = new CashBookEntities();

        Payment payment4Update = null;

        private void FrmSalesPaymentEdit_Load(object sender, EventArgs e)
        {
            ActiveControl = txtAmount;

            cmbPaymentType.DataSource = db.PaymentType.ToList();
            cmbPaymentType.DisplayMember = "PaymentTypeName";
            cmbPaymentType.ValueMember = "PaymentTypeID";


            payment4Update = db.Payment.Where(q => q.PaymentID == this.paymentID && q.IsDeleted == false).FirstOrDefault();

            if (payment4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı gider bulunamadı!");
                Close();
                return;
            }


            dtTransactionTime.Value = payment4Update.PaymentTime;
            txtAmount.Text = payment4Update.Amount.ToString();

            cmbPaymentType.SelectedItem = payment4Update.PaymentType;

            txtDescription.Text = payment4Update.Description;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtAmount.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Tutar bilgisi girin!");
                    return;
                }
                if (!txtAmount.Text.Trim().IsDecimal())
                {
                    MessageHelper.InfoMessage("Tutar bilgisini kontrol edin!");
                    return;
                }

                if (cmbPaymentType.SelectedIndex == -1)
                {
                    MessageHelper.InfoMessage("Ödeme yöntemi girin!");
                    return;
                }

                if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
                {
                    DialogResult ask = MessageHelper.AskMessage("Açıklama bilgisi olmadan kaydedilsin mi?");
                    if (ask == DialogResult.No)
                    {
                        return;
                    }
                }


                payment4Update.Amount = decimal.Parse(txtAmount.Text);
                if (dtTransactionTime.Checked)
                {
                    payment4Update.PaymentTime = dtTransactionTime.Value;
                }
                payment4Update.PaymentTypeID = (cmbPaymentType.SelectedItem as PaymentType).PaymentTypeID;
                payment4Update.Description = txtDescription.Text;
                //payment4Update.IsExpense = false;


                int i = db.SaveChanges();
                if (i > 0)
                {
                    FrmSalesEdit frmSalesEdit = (FrmSalesEdit)Application.OpenForms["FrmSalesEdit"];
                    if (frmSalesEdit != null)
                    {
                        frmSalesEdit.LoadPayments();
                    }
                    FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                    if (frmPaymentList != null)
                    {
                        frmPaymentList.LoadPayments();
                    }
                    MessageHelper.InfoMessage("Ödeme bilgisi güncellendi!");
                }
                else
                {
                    MessageHelper.InfoMessage("Kayıt başarısız!");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }

        }
    }
}

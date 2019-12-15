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

namespace CashBookApp.WinForm.UI.CashBook
{
    public partial class FrmPaymentAdd : BaseForm
    {
        public FrmPaymentAdd()
        {
            InitializeComponent();
        }


        CashBookEntities db = new CashBookEntities();
        
        void ResetForm()
        {
            dtTransactionTime.Value = DateTime.Now;
            dtTransactionTime.Checked = false;
            txtAmount.Text = txtDescription.Text = "";
            cmbPaymentType.ResetText();
        }


        private void FrmPaymentAdd_Load(object sender, EventArgs e)
        {
            ActiveControl = txtAmount;

            cmbPaymentType.DataSource = db.PaymentType.ToList();
            cmbPaymentType.DisplayMember = "PaymentTypeName";
            cmbPaymentType.ValueMember = "PaymentTypeID";

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

                Payment expense = new Payment();
                expense.Amount = decimal.Parse(txtAmount.Text);
                expense.PaymentTime = dtTransactionTime.Checked ? dtTransactionTime.Value : DateTime.Now;
                expense.PaymentTypeID = (cmbPaymentType.SelectedItem as PaymentType).PaymentTypeID;
                expense.Description = txtDescription.Text;
                expense.IsExpense = true;

                db.Payment.Add(expense);

                int i = db.SaveChanges();
                if (i > 0)
                {

                    FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                    if (frmPaymentList != null)
                    {
                        frmPaymentList.LoadPayments();
                    }

                    MessageHelper.InfoMessage("Gider kaydedildi!");
                }
                else
                {
                    MessageHelper.InfoMessage("Kayıt başarısız!");
                }

                ResetForm();

            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }
    }
}
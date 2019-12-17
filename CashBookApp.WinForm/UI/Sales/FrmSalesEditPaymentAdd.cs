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
    public partial class FrmSalesEditPaymentAdd : BaseForm
    {
        public FrmSalesEditPaymentAdd(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        int orderID = 0;


        CashBookEntities db = new CashBookEntities();

        Order order = null;

        private void FrmSalesPaymentEdit_Load(object sender, EventArgs e)
        {
            order = db.Order.Where(q => q.IsDeleted == false && q.OrderID == this.orderID).FirstOrDefault();
            if (order == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış bulunamadı!");
                Close();
                return;
            }
            dtTransactionTime.Value = order.OrderDate;
            dtTransactionTime.Checked = true;

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

                Payment newPayment4Order = new Payment();
                newPayment4Order.Amount = decimal.Parse(txtAmount.Text);
                if (dtTransactionTime.Checked)
                {
                    newPayment4Order.PaymentTime = dtTransactionTime.Value;
                }
                else
                {
                    newPayment4Order.PaymentTime = DateTime.Now;
                }
                newPayment4Order.PaymentTypeID = (cmbPaymentType.SelectedItem as PaymentType).PaymentTypeID;
                newPayment4Order.Description = txtDescription.Text;
                newPayment4Order.IsExpense = false;

                order.Payment.Add(newPayment4Order);

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
                    MessageHelper.InfoMessage("Ödeme bilgisi eklendi!");
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

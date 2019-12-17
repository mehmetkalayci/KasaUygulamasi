using CashBookApp.WinForm.Helper;
using CashBookApp.WinForm.Model;
using CashBookApp.WinForm.UI.CashBook;
using CashBookApp.WinForm.UI.Client;
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
    public partial class FrmSalesReturnAddExpense : BaseForm
    {
        public FrmSalesReturnAddExpense(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        int orderID = 0;

        CashBookEntities db = new CashBookEntities();

        Order selectedOrder = null;

        private void FrmSalesPaymentEdit_Load(object sender, EventArgs e)
        {
            selectedOrder = db.Order.Where(q => q.OrderID == this.orderID && q.IsDeleted == false).FirstOrDefault();

            if (selectedOrder == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış bulunamadı!");
                Close();
                return;
            }


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


                selectedOrder.Payment.Add(expense);

                db.Payment.Add(expense);

                int i = db.SaveChanges();
                if (i > 0)
                {
                    /*
                     iade yap formunu ya da satış formunu güncelle
                     
                     */
                    FrmSalesReturn frmSalesReturn = (FrmSalesReturn)Application.OpenForms["FrmSalesReturn"];
                    if (frmSalesReturn != null)
                    {
                        frmSalesReturn.LoadOrders();
                        frmSalesReturn.LoadPayments();
                    }
                    FrmSalesList frmSalesList = (FrmSalesList)Application.OpenForms["FrmSalesList"];
                    if (frmSalesList != null)
                    {
                        frmSalesList.LoadOrders();
                    }
                    FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                    if (frmPaymentList != null)
                    {
                        frmPaymentList.LoadPayments();
                    }
                    FrmCustomerList frmCustomerList = (FrmCustomerList)Application.OpenForms["FrmCustomerList"];
                    if (frmCustomerList != null)
                    {
                        frmCustomerList.LoadCustomers();
                    }
                    MessageHelper.InfoMessage("Satış iadesi gideri kaydedildi!");
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

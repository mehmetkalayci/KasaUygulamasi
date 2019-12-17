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
    public partial class FrmSalesReturn : BaseForm
    {
        public FrmSalesReturn(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        int orderID = 0;

        CashBookEntities db = new CashBookEntities();

        Order order4Update = null;

        public void LoadOrders()
        {

            var orderDetails = db.OrderDetail.Where(q => q.OrderID == orderID && q.IsDeleted == false).Select(q => new
            {
                q.OrderDetailID,
                q.Product.Barcode,
                q.ProductName,
                q.Price,
                ActualPrice = q.Product.Price,
            }).ToList();

            dgBasket.DataSource = orderDetails;

            dgBasket.Columns[0].Visible = false;
            dgBasket.Columns[0].HeaderText = "Detay ID";
            dgBasket.Columns[1].HeaderText = "Barkod";
            dgBasket.Columns[2].HeaderText = "Ürün Adı";
            dgBasket.Columns[3].HeaderText = "Fiyat";
            dgBasket.Columns[4].HeaderText = "Şu anki Fiyat";
        }

        public void LoadPayments()
        {

            var order = db.Order.Where(q => q.OrderID == order4Update.OrderID && q.IsDeleted == false).FirstOrDefault();

            var orderPayments = db.Payment.Where(q => q.IsDeleted == false && q.Order.Any(x => x.OrderID == order.OrderID) && q.IsExpense == true).Select(q => new
            {
                q.PaymentID,
                q.PaymentTime,
                q.Amount,
                q.PaymentType.PaymentTypeName,
                q.Description
            }).ToList();


            dgPayments.DataSource = orderPayments;

            dgPayments.Columns[0].Visible = false;
            dgPayments.Columns[0].HeaderText = "Ödeme ID";
            dgPayments.Columns[1].HeaderText = "Ödeme Zamanı";
            dgPayments.Columns[2].HeaderText = "Tutar (₺)";
            dgPayments.Columns[3].HeaderText = "Ödeme Tipi";
            dgPayments.Columns[4].HeaderText = "Açıklama";
        }

        private void FrmSalesReturn_Load(object sender, EventArgs e)
        {
            order4Update = db.Order.Where(q => q.IsDeleted == false && q.OrderID == this.orderID).FirstOrDefault();

            if (order4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış bulunamadı!");
                Close();
                return;
            }

            LoadOrders();
            LoadPayments();
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmSalesReturnAddExpense>(this.order4Update.OrderID);
        }

        private void DgBasket_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBasket.SelectedRows.Count > 0)
            {
                int orderDetailID = int.Parse(dgBasket.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmSalesReturnAddDescription>(orderDetailID);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (dgPayments.SelectedRows.Count > 0)
            {
                int paymentID = int.Parse(dgPayments.SelectedRows[0].Cells[0].Value.ToString());

                var selectedPayment = db.Payment.Where(q => q.PaymentID == paymentID).FirstOrDefault();

                selectedPayment.IsDeleted = true;

                int i = db.SaveChanges();
                if (i > 0)
                {
                    /*
                     iade yap formunu ya da satış formunu güncelle
                     */

                    LoadOrders();
                    LoadPayments();

                    FrmSalesList frmSalesList = (FrmSalesList)Application.OpenForms["FrmSalesList"];
                    if (frmSalesList != null)
                    {
                        frmSalesList.LoadOrders();
                    }
                    FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                    if (frmPaymentList != null)
                    {
                        frmPaymentList.LoadPayments() ;
                    }
                    MessageHelper.InfoMessage("Satış iadesi gideri kaydedildi!");
                }
                else
                {
                    MessageHelper.InfoMessage("Kayıt başarısız!");
                }



            }
        }
    }
}

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

namespace CashBookApp.WinForm.UI.Sales
{
    public partial class FrmSalesEdit : BaseForm
    {
        public FrmSalesEdit(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        int orderID = 0;

        CashBookEntities db = new CashBookEntities();

        Order order4Update = null;


        void Add2Basket(Product p)
        {
            this.order4Update.OrderDetail.Add(new OrderDetail()
            {
                Product = p,
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price
            });

            LoadBasket();
        }


        void LoadBasket()
        {
            var orderDetails = this.order4Update.OrderDetail.Where(q => q.IsDeleted == false).Select(i => new
            {
                i.ProductID,
                i.Product.Barcode,
                i.Product.ProductName,
                i.Product.Price,
                i.Product.Color,
                i.Product.Size
            }).ToList();

            dgBasket.DataSource = orderDetails;

            txtAmount.Text = orderDetails.Sum(q => q.Price).ToString();

            lblWarning.Text = string.Format("{0} adet ürün, {1:C} ", orderDetails.Count, orderDetails.Sum(q => q.Price));
        }

        public void LoadCustomers()
        {
            // Load customers

            var customers = db.Customer.Select(q => new CustomerInfo4Combobox
            {
                CustomerID = q.CustomerID,
                FullInfo = q.FullName + " " + q.Phone,
                Name = q.FullName,
                Phone = q.Phone
            }).ToList();


            customers.Insert(0, new CustomerInfo4Combobox());

            // first record is null
            cmbCustomerName.DataSource = customers;
            cmbCustomerName.DisplayMember = "FullInfo";
            cmbCustomerName.ValueMember = "CustomerID";

        }

        public void RefreshAll()
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public void LoadPayments()
        {
            Order myOrder = db.Order.Where(q => q.IsDeleted == false && q.OrderID == order4Update.OrderID).FirstOrDefault();



            dgPayments.DataSource = myOrder.Payment.Where(q => q.IsDeleted == false).Select(q => new
            {
                q.PaymentID,
                q.Amount,
                q.PaymentType.PaymentTypeName,
                q.Description
            }).ToList();

            dgPayments.Columns[0].Visible = false;
            dgPayments.Columns[0].HeaderText = "Ödeme ID";
            dgPayments.Columns[1].HeaderText = "Tutar (₺)";
            dgPayments.Columns[2].HeaderText = "Ödeme Tipi";
            dgPayments.Columns[3].HeaderText = "Açıklama";
            
        }


        private void FrmSalesEdit_Load(object sender, EventArgs e)
        {
            this.order4Update = db.Order.Where(q => q.OrderID == this.orderID && q.IsDeleted == false).FirstOrDefault();
            //this.orderDetails = order4Update.OrderDetail.ToList();

            if (order4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış bulunamadı!");
                Close();
                return;
            }

            this.ActiveControl = txtBarcode;

            LoadBasket();
            LoadCustomers();
            LoadPayments();


            dgBasket.Columns[0].Visible = false;
            dgBasket.Columns[0].HeaderText = "Stok ID";
            dgBasket.Columns[1].HeaderText = "Barkod";
            dgBasket.Columns[2].HeaderText = "Ürün Adı";
            dgBasket.Columns[3].HeaderText = "Fiyat";
            dgBasket.Columns[4].HeaderText = "Renk";
            dgBasket.Columns[5].HeaderText = "Numara";

            dgBasket.Columns[3].DefaultCellStyle.Format = "C2";

            // Add remove button 2 grid
            dgBasket.Columns.Add(new DataGridViewButtonColumn()
            {
                Width = 30,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Padding = new Padding(2),
                    ForeColor = Color.Red,
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    NullValue = "  X  "
                }
            });

            dgBasket.RowTemplate.Height = 40;




            /*************************************************/

            dtTransactionTime.Value = order4Update.OrderDate;
            dtTransactionTime.Checked = true;

            if (order4Update.Customer != null)
            {
                cmbCustomerName.SelectedItem = order4Update.Customer;
                txtCustomerPhone.Text = order4Update.Customer.Phone;
            }


        }

        private void DgPayments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPayments.SelectedRows.Count > 0)
            {
                int paymentID = int.Parse(dgPayments.SelectedRows[0].Cells[0].Value.ToString());

                FormHelper.ShowDialog<FrmSalesPaymentEdit>(paymentID);

            }
        }

        private void TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();

                Product selectedProduct = db.Product.Where(q => q.Barcode == barcode).FirstOrDefault();


                if (selectedProduct == null)
                {
                    lblWarning.Text = "Barkod sistemde kayıtlı değil!";
                    txtBarcode.Clear();
                    return;
                }

                Add2Basket(selectedProduct);
                txtBarcode.Clear();
            }
        }

        private void DgBasket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                int productID = int.Parse(dgBasket.Rows[e.RowIndex].Cells[0].Value.ToString());

                this.order4Update.OrderDetail.Where(q=>q.ProductID == productID);
                LoadBasket();
            }

            this.ActiveControl = txtBarcode;
        }
    }


}

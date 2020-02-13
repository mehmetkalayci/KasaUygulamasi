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
            order4Update.OrderDetail.Add(new OrderDetail()
            {
                Product = p,
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price,
                IsDeleted = false
            });

            int i = db.SaveChanges();

            LoadBasket();
        }


        void LoadBasket()
        {
            dgBasket.Columns.Clear();
            dgBasket.RowTemplate.Height = 40;


            Order myOrder = db.Order.Where(q => q.OrderID == this.orderID && q.IsDeleted == false).FirstOrDefault();

            var orderDetails = myOrder.OrderDetail.Where(q => q.IsDeleted == false).Select(i => new
            {
                i.OrderDetailID,
                i.ProductID,
                i.Product.Barcode,
                i.Product.ProductName,
                i.Product.Price,
                i.Product.Color,
                i.Product.Size
            }).ToList();

            dgBasket.DataSource = orderDetails;


            dgBasket.Columns[0].Visible = false;
            dgBasket.Columns[0].HeaderText = "Satış Detay ID";
            dgBasket.Columns[1].HeaderText = "Stok ID";
            dgBasket.Columns[2].HeaderText = "Barkod";
            dgBasket.Columns[3].HeaderText = "Ürün Adı";

            dgBasket.Columns[4].HeaderText = "Fiyat";
            dgBasket.Columns[4].DefaultCellStyle.Format = "C";


            dgBasket.Columns[5].HeaderText = "Renk";
            dgBasket.Columns[6].HeaderText = "Numara";


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


        public void LoadPayments()
        {
            Order myOrder = db.Order.Where(q => q.IsDeleted == false && q.OrderID == order4Update.OrderID).FirstOrDefault();

            var orderPayments = db.Payment.Where(q => q.IsDeleted == false && q.Order.Any(x => x.OrderID == myOrder.OrderID)).Select(q => new
            {
                q.PaymentID,
                q.Amount,
                q.PaymentType.PaymentTypeName,
                q.Description
            }).ToList();


            dgPayments.DataSource = orderPayments;


            dgPayments.Columns[0].Visible = false;
            dgPayments.Columns[0].HeaderText = "Ödeme ID";

            dgPayments.Columns[1].HeaderText = "Tutar (₺)";
            //dgPayments.Columns[1].DefaultCellStyle.Format = "C";

            dgPayments.Columns[2].HeaderText = "Ödeme Tipi";
            dgPayments.Columns[3].HeaderText = "Açıklama";

        }



        private void FrmSalesEdit_Load(object sender, EventArgs e)
        {
            this.order4Update = db.Order.Where(q => q.OrderID == this.orderID && q.IsDeleted == false).FirstOrDefault();

            if (order4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış bulunamadı!");
                Close();
                return;
            }

            LoadBasket();
            LoadPayments();
            LoadCustomers();
            try
            {


                cmbCustomerName.SelectedValue = order4Update.Customer.CustomerID;
                txtCustomerPhone.Text = order4Update.Customer.Phone;

                dtTransactionTime.Value = order4Update.OrderDate;
                dtTransactionTime.Checked = true;


            }
            catch 
            {

            }


        }

        private void DgPayments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPayments.SelectedRows.Count > 0)
            {
                int paymentID = int.Parse(dgPayments.SelectedRows[0].Cells[0].Value.ToString());

                FormHelper.ShowDialog<FrmSalesEditPaymentEdit>(paymentID);
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

            if (e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                int orderDetailID = int.Parse(dgBasket.Rows[e.RowIndex].Cells[0].Value.ToString());

                var selectedOrderDetail = db.OrderDetail.Where(q => q.OrderDetailID == orderDetailID).FirstOrDefault();
                selectedOrderDetail.IsDeleted = true;

                int i = db.SaveChanges();
                if (i > 0)
                {
                    LoadBasket();
                }
            }

            this.ActiveControl = txtBarcode;
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmSalesEditPaymentAdd>(this.orderID);
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            /*  3. Müşteriyi satışa ekle   */
            Order myOrder = db.Order.Where(q => q.OrderID == this.orderID && q.IsDeleted == false).FirstOrDefault();

            if (cmbCustomerName.SelectedItem != null)
            {
                // get customerInfo
                int selectedCustomerID = (cmbCustomerName.SelectedItem as CustomerInfo4Combobox).CustomerID;

                Customer customer = db.Customer.Where(q => q.CustomerID == selectedCustomerID).FirstOrDefault();

                if (customer != null)
                {
                    // müşteri numarası güncellensin mi?
                    if (txtCustomerPhone.Text != customer.Phone)
                    {
                        DialogResult isUpdate = MessageHelper.AskMessage("Müşteri telefon numarası güncellensin mi?");
                        if (isUpdate == DialogResult.Yes)
                        {
                            customer.Phone = txtCustomerPhone.Text;
                        }
                    }

                    myOrder.Customer = customer;
                    myOrder.CustomerID = customer.CustomerID;
                }
            }
            else
            {
                if (cmbCustomerName.Text != "")
                {
                    // create new customer
                    Customer newCustomer = new Customer();
                    newCustomer.CreatedAt = DateTime.Now;
                    newCustomer.FullName = cmbCustomerName.Text;
                    newCustomer.Phone = txtCustomerPhone.Text;

                    // add customer 2 sales
                    Customer customerAdded = db.Customer.Add(newCustomer);
                    myOrder.CustomerID = customerAdded.CustomerID;
                }
            }


            if (dtTransactionTime.Checked)
            {
                myOrder.OrderDate = dtTransactionTime.Value;
            }

            int i = db.SaveChanges();
            if (i > 0)
            {
                MessageHelper.InfoMessage("Satış değiikleri kaydedildi!");
            }

            FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
            if (frmPaymentList != null)
            {
                frmPaymentList.LoadPayments();
            }
            // yeni müşteri eklenmiş olabilir, müşterileri yenile
            LoadCustomers();

        }

        private void CmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedItem != null)
            {
                txtCustomerPhone.Text = ((CustomerInfo4Combobox)cmbCustomerName.SelectedItem).Phone;
            }
            else
            {
                txtCustomerPhone.Text = "";
            }
        }

        private void FrmSalesEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSalesList frmSalesList = (FrmSalesList)Application.OpenForms["FrmSalesList"];
            if (frmSalesList != null)
            {
                frmSalesList.LoadOrders();
            }
        }

        private void btnDelPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPayments.SelectedRows.Count > 0)
                {
                    int paymentID = int.Parse(dgPayments.SelectedRows[0].Cells[0].Value.ToString());

                    if (MessageHelper.AskMessage("Ödeme silinsin mi?") == DialogResult.Yes)
                    {
                        Payment selectedPayment = db.Payment.Where(q => q.PaymentID == paymentID && q.IsDeleted == false).FirstOrDefault();
                        selectedPayment.IsDeleted = true;

                        int num = db.SaveChanges();

                        if (num > 0)
                        {
                            LoadPayments();

                            FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                            if (frmPaymentList != null)
                            {
                                frmPaymentList.LoadPayments();
                            }

                            MessageHelper.InfoMessage("Ödeme silindi!");
                        }
                        else
                        {
                            MessageHelper.InfoMessage("Hata!");
                        }
                    }
                }
                else
                {
                    MessageHelper.InfoMessage("Listeden ödeme seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmSalesReturn>(this.orderID);
        }
    }


}

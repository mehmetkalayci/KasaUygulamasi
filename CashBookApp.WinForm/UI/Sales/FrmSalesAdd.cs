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
    public partial class FrmSalesAdd : BaseForm
    {
        public FrmSalesAdd()
        {
            InitializeComponent();
        }


        CashBookEntities db = new CashBookEntities();

        List<OrderDetail> orderDetails = new List<OrderDetail>();

        void LoadBasket()
        {
            dgBasket.DataSource = this.orderDetails.Select(i => new
            {
                i.ProductID,
                i.Product.Barcode,
                i.Product.ProductName,
                i.Product.Price,
                i.Product.Color,
                i.Product.Size
            }).ToList();



            txtAmount.Text = this.orderDetails.Sum(q => q.Price).ToString();

            lblWarning.Text = string.Format("{0} adet ürün, {1:C} ", this.orderDetails.Count, this.orderDetails.Sum(q => q.Price));
            //txtPaymentVal1.Text = this.basket.Sum(q => q.Price).ToString();
        }

        void Add2Basket(Product p)
        {
            this.orderDetails.Add(new OrderDetail()
            {
                Product = p,
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Price = p.Price
            });

            LoadBasket();
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


        void Reset()
        {
            dtTransactionTime.Value = DateTime.Now;
            dtTransactionTime.Checked = false;

            txtCustomerPhone.Text = txtAmount.Text = txtTakenAmount.Text = txtChange.Text = "";
            cmbCustomerName.ResetText();

            this.orderDetails.Clear();
            LoadBasket();

            dgPayments.Rows.Clear();
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

        private void CmbCustomer_Format(object sender, ListControlConvertEventArgs e)
        {
            //e.Value = (e.ListItem as Customer).FullName + " " + (e.ListItem as Customer).Phone;
        }

        private void FrmSalesAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;

            LoadBasket();
            LoadCustomers();



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


            // add payment methods to the dgpayments' combobox


            DataGridViewComboBoxColumn dgPaymentsCombobox = (DataGridViewComboBoxColumn)this.dgPayments.Columns["ColumnPaymentType"];

            dgPaymentsCombobox.DataSource = db.PaymentType.Where(q => q.IsDeleted == false).ToList();
            dgPaymentsCombobox.DisplayMember = "PaymentTypeName";
            dgPaymentsCombobox.ValueMember = "PaymentTypeID";
        }

        private void CmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
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

        private void DgBasket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                this.orderDetails.RemoveAt(dgBasket.Rows[e.RowIndex].Index);
                LoadBasket();
            }

            this.ActiveControl = txtBarcode;
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            dgPayments.Rows.Add(1);
        }

        private void BtnDelPayment_Click(object sender, EventArgs e)
        {
            if (dgPayments.SelectedRows.Count > 0)
            {
                dgPayments.Rows.RemoveAt(dgPayments.SelectedRows[0].Index);
            }
        }


        private void KeyPressMoney(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtTakenAmount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal amount = decimal.Parse(txtAmount.Text);
                decimal taken = decimal.Parse(txtTakenAmount.Text);

                txtChange.Text = (taken - amount).ToString();
            }
            catch
            {

            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (this.orderDetails.Count <= 0)
            {
                MessageHelper.InfoMessage("Ürün eklemediniz!");
                return;
            }

            if (dgPayments.Rows.Count <= 0)
            {
                MessageHelper.InfoMessage("Ödeme bilgisi eklemediniz!");
                return;
            }

            try
            {
                /*  1.Satış oluştur  */
                Order order = new Order();
                if (dtTransactionTime.Checked)
                {
                    order.OrderDate = dtTransactionTime.Value;
                }
                else
                {
                    order.OrderDate = DateTime.Now;
                }

                /*  2. Ürünleri satışa ekle  */
                foreach (var item in this.orderDetails)
                {
                    OrderDetail detail = new OrderDetail();
                    detail = item;
                    detail.Price = item.Price;
                    detail.ProductName = item.ProductName;
                    detail.Product.Quantity--;

                    order.OrderDetail.Add(item);
                }


                /*  3. Müşteriyi satışa ekle   */

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

                        order.Customer = customer;
                        order.CustomerID = customer.CustomerID;
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
                        order.CustomerID = customerAdded.CustomerID;
                    }
                }

                /*  4. Ödemeleri satışa ekle  */
                for (int rows = 0; rows < dgPayments.Rows.Count; rows++)
                {
                    object oAmount = dgPayments.Rows[rows].Cells[0].Value;

                    if (oAmount == null)
                    {
                        MessageHelper.WarnMessage(string.Format("Ödeme yöntemi {0} 'e tutar girin!", rows + 1));
                        return;
                    }

                    if (!oAmount.ToString().IsDecimal())
                    {
                        MessageHelper.WarnMessage(string.Format("Ödeme yöntemi {0} 'deki girilen tutar hatalı!", rows + 1));
                        return;
                    }

                    if ((dgPayments.Rows[rows].Cells[1] as DataGridViewComboBoxCell).Value == null)
                    {
                        MessageHelper.WarnMessage(string.Format("Ödeme yöntemi {0} 'e ödeme tipi seçin!", rows + 1));
                        return;
                    }


                    object oDescription = dgPayments.Rows[rows].Cells[2].Value;
                    string description = "";

                    if (oDescription != null && oDescription.ToString().Trim() != "")
                    {
                        description = oDescription.ToString();
                    }

                    Payment newPayment = new Payment();

                    newPayment.PaymentTime = order.OrderDate; // sipariş tarihine eit

                    newPayment.Amount = decimal.Parse(oAmount.ToString());
                    newPayment.PaymentTypeID = int.Parse((dgPayments.Rows[rows].Cells[1] as DataGridViewComboBoxCell).Value.ToString());
                    newPayment.Description = description;
                    newPayment.IsExpense = false;
                    newPayment.IsDeleted = false;

                    order.Payment.Add(newPayment);
                }


                db.Order.Add(order);

                int i = db.SaveChanges();
                if (i > 0)
                {
                    MessageHelper.InfoMessage("Satış tamamlandı!");
                }

                FrmPaymentList frmPaymentList = (FrmPaymentList)Application.OpenForms["FrmPaymentList"];
                if (frmPaymentList != null)
                {
                    frmPaymentList.LoadPayments();
                }
                // yeni müşteri eklenmiş olabilir, müşterileri yenile
                LoadCustomers();


            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }

            Reset();
        }

        private void CmbCustomerName_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index > -1)
            {
                Customer item = cmbCustomerName.Items[e.Index] as Customer;
                e.Graphics.DrawString(item.FullName + " " + item.Phone, e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void CmbCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }


    class CustomerInfo4Combobox
    {
        public int CustomerID { get; set; }
        public string FullInfo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

}

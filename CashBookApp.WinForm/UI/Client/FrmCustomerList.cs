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
    public partial class FrmCustomerList : BaseForm
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        CashBookEntities db = new CashBookEntities();

        #region functions

        public void LoadShoppings(int customerID)
        {
            var shoppings = db.Order.Where(q => q.CustomerID == customerID && q.IsDeleted == false).Select(q=>q.OrderID).ToList();

            var orderDetails = db.OrderDetail.Where(item =>  shoppings.Contains(item.OrderID)).Select(q => new
            {
                q.Product.Barcode,
                q.ProductName,
                q.Price,
                ActualPrice = q.Product.Price,
            }).ToList();



            dgDataShoppings.DataSource = orderDetails;
            toolStripStatusLabelCountShoppings.Text = string.Format("{0} adet ürün", orderDetails.Count);

            dgDataShoppings.Columns[0].HeaderText = "Barkod";
            dgDataShoppings.Columns[1].HeaderText = "Fiyat";
            dgDataShoppings.Columns[2].HeaderText = "Stok Adı";

            dgDataShoppings.Columns[3].HeaderText = "Şu anki Fiyat";
        }

        public void LoadCustomers()
        {
            var customers = db.Customer.Where(q=>q.IsDeleted == false).Select(q => new
            {
                q.CustomerID,
                q.FullName,
                q.Phone,
                q.CreatedAt
            }).ToList();

            dgDataCustomers.DataSource = customers;
            toolStripStatusLabelCountCustomer.Text = string.Format("{0} adet müşteri", customers.Count);

            dgDataCustomers.Columns[0].HeaderText = "Müşteri ID";
            dgDataCustomers.Columns[1].HeaderText = "Ad Soyad";
            dgDataCustomers.Columns[2].HeaderText = "Telefon";
            dgDataCustomers.Columns[3].HeaderText = "Eklenme Tarihi";

            dgDataCustomers.Columns[0].Visible = false;
        }

        public void LoadFilter()
        {
            var customers = db.Customer.Where(q => q.IsDeleted == false).Select(q => new
            {
                q.CustomerID,
                q.FullName,
                q.Phone,
                q.CreatedAt
            }).AsQueryable();

            if (txtFullName.Text.Trim().Length > 0)
            {
                customers = customers.Where(q => q.FullName.ToString().ToLower().Contains(txtFullName.Text.ToLower()));
            }
            if (txtPhone.Text.Trim().Length > 0)
            {
                customers = customers.Where(q => q.Phone.ToString().ToLower().Contains(txtPhone.Text.ToLower()));
            }


            var filteredCustomers = customers.ToList();

            dgDataCustomers.DataSource = filteredCustomers;
            toolStripStatusLabelCountCustomer.Text = string.Format("{0} adet müşteri", filteredCustomers.Count);

            dgDataCustomers.Columns[0].HeaderText = "Müşteri ID";
            dgDataCustomers.Columns[1].HeaderText = "Ad Soyad";
            dgDataCustomers.Columns[2].HeaderText = "Telefon";
            dgDataCustomers.Columns[3].HeaderText = "Eklenme Tarihi";

            dgDataCustomers.Columns[0].Visible = false;
        }

        void CleanFilter()
        {
            txtFullName.Text = txtPhone.Text = "";
            LoadCustomers();
        }

        #endregion

        #region filters

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CleanFilter();
        }

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoadFilter();
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        #endregion

        #region toolstrip buttons

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgDataCustomers.SelectedRows.Count > 0)
                {
                    int customerID = int.Parse(dgDataCustomers.SelectedRows[0].Cells[0].Value.ToString());

                    if (MessageHelper.AskMessage("Müşteri silinsin mi?") == DialogResult.Yes)
                    {
                        Customer selectedCustomer = db.Customer.Where(q => q.CustomerID == customerID).FirstOrDefault();
                        selectedCustomer.IsDeleted = true;

                        int num = db.SaveChanges();

                        if (num > 0)
                        {
                            LoadCustomers();

                            /*
                             BURAYA ANASAYFADAKİ MÜŞTERİLERİ GÜNCELLEME METODU EKLENECEK
                             */

                            MessageHelper.InfoMessage("Müşteri silindi!");
                        }
                        else
                        {
                            MessageHelper.InfoMessage("Hata!");
                        }
                    }
                }
                else
                {
                    MessageHelper.InfoMessage("Listeden müşteri seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }

        private void ToolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dgDataCustomers.SelectedRows.Count > 0)
            {
                int customerID = int.Parse(dgDataCustomers.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmCustomerEdit>(customerID);
            }
            else
            {
                MessageHelper.InfoMessage("Listeden müşteri seçin!");
            }
        }

        private void ToolStripButtonFilter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !toolStripButtonFilter.Checked;
        }

        private void ToolStripButtonExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgDataCustomers, "Müşteri Listesi.xlsx");
            excelHelper.ShowDialog();
        }

        #endregion

        private void DgDataCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToolStripButtonUpdate_Click(sender, e);
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            LoadCustomers();
        }

        private void DgDataCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDataCustomers.SelectedRows.Count > 0)
            {
                int customerID = int.Parse(dgDataCustomers.SelectedRows[0].Cells[0].Value.ToString());
                LoadShoppings(customerID);
            }
            else
            {
                dgDataShoppings.DataSource = null;
            }
        }
    }
}

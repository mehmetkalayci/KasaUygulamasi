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
    public partial class FrmSalesList : BaseForm
    {
        public FrmSalesList()
        {
            InitializeComponent();
        }


        CashBookEntities db = new CashBookEntities();

        #region functions


        void LoadOrders()
        {
            var orders = db.Order.Where(q => q.IsDeleted == false).Select(q => new
            {
                q.OrderID,
                q.OrderDate,
                q.Customer.FullName,
                q.Customer.Phone,
                Pay = q.Payment.Count + " adet ödeme",
                Total = q.Payment.Sum(x => x.Amount).ToString()
            }).ToList();

            dgDataOrders.DataSource = orders;
            toolStripStatusLabelCountOrders.Text = string.Format("{0} adet satış", orders.Count);

            dgDataOrders.Columns[0].Visible = false;
            dgDataOrders.Columns[0].HeaderText = "Satış ID";
            dgDataOrders.Columns[1].HeaderText = "Satış Tarihi";
            dgDataOrders.Columns[2].HeaderText = "Müşteri Ad Soyad";
            dgDataOrders.Columns[3].HeaderText = "Müşteri Telefon";
            dgDataOrders.Columns[4].HeaderText = "Ödemeler";
            dgDataOrders.Columns[5].HeaderText = "Ödenen Tutar";
        }

        void LoadOrderDetails(int orderID)
        {
            var orderDetails = db.OrderDetail.Where(q => q.OrderID == orderID && q.IsDeleted == false).Select(q => new
            {
                q.Product.Barcode,
                q.ProductName,
                q.Price,
                ActualPrice = q.Product.Price,
            }).ToList();

            dgDataOrderDetails.DataSource = orderDetails;
            toolStripStatusLabelCountOrders.Text = string.Format("{0} adet ürün", orderDetails.Count);

            dgDataOrderDetails.Columns[0].HeaderText = "Barkod";
            dgDataOrderDetails.Columns[1].HeaderText = "Ürün Adı";
            dgDataOrderDetails.Columns[2].HeaderText = "Fiyat";
            dgDataOrderDetails.Columns[3].HeaderText = "Şu anki Fiyat";
        }

        #endregion



        private void FrmSalesList_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            LoadOrders();
        }

        private void DgDataOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDataOrders.SelectedRows.Count > 0)
            {
                int orderID = int.Parse(dgDataOrders.SelectedRows[0].Cells[0].Value.ToString());
                LoadOrderDetails(orderID);
            }
            else
            {
                dgDataOrderDetails.DataSource = null;
            }
        }

        private void DgDataOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgDataOrders.SelectedRows.Count > 0)
                {
                    int orderID = int.Parse(dgDataOrders.SelectedRows[0].Cells[0].Value.ToString());

                    if (MessageHelper.AskMessage("Satış silinsin mi?") == DialogResult.Yes)
                    {
                        Order selectedOrder = db.Order.Where(q => q.OrderID == orderID && q.IsDeleted == false).FirstOrDefault();
                        selectedOrder.IsDeleted = true;

                        int num = db.SaveChanges();

                        if (num > 0)
                        {
                            LoadOrders();

                            MessageHelper.InfoMessage("Satış silindi!");
                        }
                        else
                        {
                            MessageHelper.InfoMessage("Hata!");
                        }
                    }
                }
                else
                {
                    MessageHelper.InfoMessage("Listeden satış seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }

        private void ToolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dgDataOrders.SelectedRows.Count > 0)
            {
                int orderID = int.Parse(dgDataOrders.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmEditSales>(orderID);
            }
            else
            {
                MessageHelper.InfoMessage("Listeden satış seçin!");
            }
        }

        private void ToolStripButtonFilter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !toolStripButtonFilter.Checked;
        }

        private void ToolStripButtonExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgDataOrders, "Satış Listesi.xlsx");
            excelHelper.ShowDialog();
        }
    }
}

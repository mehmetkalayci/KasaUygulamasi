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

namespace CashBookApp.WinForm.UI.Stock
{
    public partial class FrmStockEdit : BaseForm
    {
        public FrmStockEdit(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        int productID = 0;

        CashBookEntities db = new CashBookEntities();

        Product product4Update = null;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBarcode.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Barkod girin!");
                    return;
                }
                if (product4Update.Barcode != txtBarcode.Text.Trim() &&  db.Product.Where(q => q.Barcode == txtBarcode.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageHelper.InfoMessage("Girilen barkod başka bir ürüne ait!");
                    return;
                }
                if (String.IsNullOrEmpty(txtProductName.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Ürün adı girin!");
                    return;
                }
                if (String.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Fiyat girin!");
                    return;
                }
                if (!txtPrice.Text.IsDecimal())
                {
                    MessageHelper.InfoMessage("Fiyat bilgisini kontrol edin!");
                    return;
                }
                if (String.IsNullOrEmpty(txtInstallmentPrice.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Taksitli fiyat girin!");
                    return;
                }
                if (!txtInstallmentPrice.Text.Trim().IsDecimal())
                {
                    MessageHelper.InfoMessage("Taksitli fiyat bilgisini kontrol edin!");
                    return;
                }

                product4Update.Barcode = txtBarcode.Text;
                product4Update.ProductName = txtProductName.Text;
                product4Update.Price = decimal.Parse(txtPrice.Text);
                product4Update.InstallmentPrice = decimal.Parse(txtInstallmentPrice.Text);
                if (dtCreatedAt.Checked)
                {
                    product4Update.CreatedAt = dtCreatedAt.Value;
                }

                product4Update.Color = txtColor.Text;
                product4Update.Size = txtSize.Text;

                if (txtStockQuantity.Text.Trim().IsInt())
                {
                    product4Update.Quantity = int.Parse(txtStockQuantity.Text);
                }

                if (db.Entry(product4Update).State == System.Data.Entity.EntityState.Unchanged)
                {
                    DialogResult result = MessageHelper.AskMessage("Değişiklik yapmadınız, güncelleme penceresini kapatmak ister misiniz?");
                    if (result == DialogResult.Yes)
                    {
                        Close();
                    }
                }

                int i = db.SaveChanges();
                if (i > 0)
                {

                    FrmStockList FrmStockList = (FrmStockList)Application.OpenForms["FrmStockList"];
                    if (FrmStockList != null)
                    {
                        FrmStockList.LoadStocks();
                    }

                    MessageHelper.InfoMessage("Stok güncellendi!");
                }
                else
                {
                    if (db.Entry(product4Update).State != System.Data.Entity.EntityState.Unchanged)
                    {
                        MessageHelper.InfoMessage("Güncelleme başarısız!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }

        }

        private void TxtStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmStockAdd_Load(object sender, EventArgs e)
        {
            ActiveControl = txtBarcode;

            product4Update = db.Product.Where(q => q.ProductID == this.productID && q.IsDeleted == false).FirstOrDefault();

            if (product4Update == null)
            {
                MessageHelper.WarnMessage("Kayıtlı stok bulunamadı!");
                Close();
                return;
            }

            txtBarcode.Text = product4Update.Barcode;
            txtProductName.Text = product4Update.ProductName;
            txtPrice.Text = product4Update.Price.ToString();
            txtInstallmentPrice.Text = product4Update.InstallmentPrice.ToString();
            dtCreatedAt.Value = product4Update.CreatedAt;
            txtColor.Text = product4Update.Color;
            txtSize.Text = product4Update.Size;
            txtStockQuantity.Text = product4Update.Quantity.ToString();
        }
    }
}

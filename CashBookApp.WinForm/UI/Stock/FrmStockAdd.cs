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
    public partial class FrmStockAdd : BaseForm
    {
        public FrmStockAdd()
        {
            InitializeComponent();
        }



        CashBookEntities db = new CashBookEntities();


        void ResetForm()
        {
            txtBarcode.Text =
            txtProductName.Text =
            txtPrice.Text =
            txtColor.Text =
            txtSize.Text =
            txtStockQuantity.Text =
            txtSize.Text = "";

            dtCreatedAt.Value = DateTime.Now;
            dtCreatedAt.Checked = false;

            ActiveControl = txtBarcode;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBarcode.Text.Trim()))
                {
                    MessageHelper.InfoMessage("Barkod girin!");
                    return;
                }
                if (db.Product.Where(q => q.Barcode == txtBarcode.Text.Trim()).FirstOrDefault() != null)
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


                Product newProduct = new Product();
                newProduct.Barcode = txtBarcode.Text;
                newProduct.ProductName = txtProductName.Text;
                newProduct.Price = decimal.Parse(txtPrice.Text);
                if (dtCreatedAt.Checked)
                {
                    newProduct.CreatedAt = dtCreatedAt.Value;
                }
                else
                {
                    newProduct.CreatedAt = DateTime.Now;
                }
                newProduct.Color = txtColor.Text;
                newProduct.Size = txtSize.Text;
                if (txtStockQuantity.Text.Trim().IsInt())
                {
                    newProduct.Quantity = int.Parse(txtStockQuantity.Text);
                }

                db.Product.Add(newProduct);

                int i = db.SaveChanges();
                if (i > 0)
                {

                    FrmStockList FrmStockList = (FrmStockList)Application.OpenForms["FrmStockList"];
                    if (FrmStockList != null)
                    {
                        FrmStockList.LoadStocks();
                    }

                    MessageHelper.InfoMessage("Stok kaydedildi!");
                }
                else
                {
                    MessageHelper.InfoMessage("Kayıt başarısız!");
                }

            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }

            ResetForm();
        }

        private void TxtStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmStockAdd_Load(object sender, EventArgs e)
        {
            ActiveControl = txtBarcode;
        }
    }
}

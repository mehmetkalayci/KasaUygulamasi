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
    public partial class FrmSalesReturnAddDescription : BaseForm
    {
        public FrmSalesReturnAddDescription(int orderDetailID)
        {
            InitializeComponent();
            this.orderDetailID = orderDetailID;
        }

        int orderDetailID = 0;

        CashBookEntities db = new CashBookEntities();

        OrderDetail selectedOrderDetail = null;


        private void FrmAddReturnDescription4Product_Load(object sender, EventArgs e)
        {
            selectedOrderDetail = db.OrderDetail.Where(q => q.OrderDetailID == this.orderDetailID && q.IsDeleted == false).FirstOrDefault();

            if (selectedOrderDetail == null)
            {
                MessageHelper.WarnMessage("Kayıtlı satış detayı bulunamadı!");
                Close();
                return;
            }

            txtDescription.Text = selectedOrderDetail.ProductName + " İADE";

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                selectedOrderDetail.ProductName = txtDescription.Text;
                if (chkProducts.Checked)
                {
                    selectedOrderDetail.Product.Quantity++;
                }

                int i = db.SaveChanges();
                if (i > 0)
                {
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
                    MessageHelper.InfoMessage("Açıklama kaydedildi!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
            Close();
        }
    }
}

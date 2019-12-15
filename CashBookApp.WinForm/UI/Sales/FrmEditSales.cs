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
    public partial class FrmEditSales : BaseForm
    {
        public FrmEditSales(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        int orderID = 0;

        Order selectedOrder = null;

        CashBookEntities db = new CashBookEntities();

        private void FrmEditSales_Load(object sender, EventArgs e)
        {
            selectedOrder = db.Order.Where(q => q.OrderID == orderID && q.IsDeleted == false).FirstOrDefault();
            if (selectedOrder == null)
            {
                MessageHelper.WarnMessage("Böyle bir satış yok!");
                Close();
                return;
            }
        }
    }
}

using CashBookApp.WinForm.Helper;
using CashBookApp.WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBookApp.WinForm.UI.CashBook
{
    public partial class FrmPaymentList : BaseForm
    {
        public FrmPaymentList()
        {
            InitializeComponent();
        }

        CashBookEntities db = new CashBookEntities();

        #region functions

        void Reset()
        {
            dtTransactionTimeStart.Value = dtTransactionTimeStart.Value = DateTime.Today.Date;
            dtTransactionTimeStart.Checked = dtTransactionTimeEnd.Checked = chkExpenses.Checked = false;
            txtDescription.Text = "";
            cmbPaymentType.ResetText();

            LoadPayments();
        }

        private void ApplyStyle2Grid()
        {
            for (int i = 0; i < dgPaymentList.Rows.Count; i++)
            {
                if (bool.Parse(dgPaymentList.Rows[i].Cells["IsExpense"].Value.ToString()))
                {
                    dgPaymentList.Rows[i].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
            }
        }

        public void LoadPayments()
        {
            var payments = db.Payment.Where(i => DbFunctions.TruncateTime(i.PaymentTime) == DateTime.Today.Date && i.IsDeleted == false).Select(i => new
            {
                i.PaymentID,
                i.PaymentTime,
                i.Amount,
                i.PaymentType.PaymentTypeName,
                i.Description,
                i.IsExpense
            }).ToList();



            dgPaymentList.DataSource = payments;
            toolStripStatusLabelTransactionCount.Text = string.Format("{0} adet işlem", payments.Count);
            /* Payment Grid */
            dgPaymentList.Columns[0].HeaderText = "İşlem ID";
            dgPaymentList.Columns[1].HeaderText = "İşlem Zamanı";
            dgPaymentList.Columns[2].HeaderText = "Tutar";
            dgPaymentList.Columns[3].HeaderText = "Ödeme Tipi";
            dgPaymentList.Columns[4].HeaderText = "Açıklama";
            dgPaymentList.Columns[5].HeaderText = "Gider Mi?";


            /*************************/

            var payments4Summary = db.Payment.Where(i => DbFunctions.TruncateTime(i.PaymentTime) == DateTime.Today.Date && i.IsDeleted == false).Select(i => new
            {
                i.PaymentID,
                i.PaymentTime,
                i.Amount,
                i.PaymentType.PaymentTypeName,
                i.Description,
                i.IsExpense

            }).ToList();

            var paymentSummary = payments4Summary
            .GroupBy(i => i.PaymentTypeName)
            .Select(group => new
            {
                TType1 = group.Key,
                Income = group.Sum(s => !s.IsExpense ? s.Amount : 0),
                Expense = group.Sum(s => s.IsExpense ? s.Amount : 0),
                Difference = group.Sum(s => s.IsExpense ? -s.Amount : s.Amount),
                gelirsayisi = group.Count(i => i.IsExpense == false),
                gidersayisi = group.Count(i => i.IsExpense == true),
            }).ToList();

            dgSummary.DataSource = paymentSummary;
            /* Summary Grid */
            dgSummary.Columns[0].HeaderText = "Ödeme Yöntemi";
            dgSummary.Columns[1].HeaderText = "Gelir";
            dgSummary.Columns[2].HeaderText = "Gider";
            dgSummary.Columns[3].HeaderText = "Toplam";
            dgSummary.Columns[4].HeaderText = "Gelir İşlem Sayısı";
            dgSummary.Columns[5].HeaderText = "Gider İşlem Sayısı";

            ApplyStyle2Grid();
        }

        public void LoadFilter()
        {
            var results = db.Payment.Where(q => q.IsDeleted == false).Select(i => new
            {
                i.PaymentID,
                i.PaymentTime,
                i.Amount,
                i.PaymentType.PaymentTypeName,
                i.Description,
                i.IsExpense
            }).AsQueryable();

            if (dtTransactionTimeStart.Checked)
            {
                results = results.Where(q => q.PaymentTime >= dtTransactionTimeStart.Value);
            }
            else
            {
                results = results.Where(i => DbFunctions.TruncateTime(i.PaymentTime) >= DateTime.Today.Date);
            }

            if (dtTransactionTimeEnd.Checked)
            {
                results = results.Where(q => q.PaymentTime <= dtTransactionTimeEnd.Value);
            }
            else
            {
                results = results.Where(i => DbFunctions.TruncateTime(i.PaymentTime) <= DateTime.Today.Date);
            }


            if (cmbPaymentType.SelectedIndex >= 0 && cmbPaymentType.Text.Trim() != "")
            {
                results = results.Where(q => q.PaymentTypeName.ToLower() == cmbPaymentType.Text.ToString().ToLower());
            }

            if (txtDescription.Text.Trim().Length > 0)
            {
                results = results.Where(q => q.Description.ToString().ToLower().Contains(txtDescription.Text.ToLower()));
            }
            if (chkExpenses.Checked)
            {
                results = results.Where(q => q.IsExpense == true);
            }

            var filteredStocks = results.ToList();

            dgPaymentList.DataSource = filteredStocks;
            toolStripStatusLabelTransactionCount.Text = string.Format("{0} adet işlem", filteredStocks.Count);

            dgPaymentList.Columns[0].HeaderText = "İşlem ID";
            dgPaymentList.Columns[1].HeaderText = "İşlem Zamanı";
            dgPaymentList.Columns[2].HeaderText = "Tutar";
            dgPaymentList.Columns[3].HeaderText = "Ödeme Tipi";
            dgPaymentList.Columns[4].HeaderText = "Açıklama";
            dgPaymentList.Columns[5].HeaderText = "Gider Mi?";

            /************************/


            var salesSummary = filteredStocks
            .GroupBy(i => i.PaymentTypeName)
            .Select(group => new
            {
                TType1 = group.Key,
                Income = group.Sum(s => !s.IsExpense ? s.Amount : 0),
                Expense = group.Sum(s => s.IsExpense ? s.Amount : 0),
                Difference = group.Sum(s => s.IsExpense ? -s.Amount : s.Amount),
                gelirsayisi = group.Count(i => i.IsExpense == false),
                gidersayisi = group.Count(i => i.IsExpense == true),
            }).ToList();

            dgSummary.DataSource = salesSummary;
            /* Summary Grid */
            dgSummary.Columns[0].HeaderText = "Ödeme Yöntemi";
            dgSummary.Columns[1].HeaderText = "Gelir";
            dgSummary.Columns[2].HeaderText = "Gider";
            dgSummary.Columns[3].HeaderText = "Toplam";
            dgSummary.Columns[4].HeaderText = "Gelir İşlem Sayısı";
            dgSummary.Columns[5].HeaderText = "Gider İşlem Sayısı";

            ApplyStyle2Grid();
        }

        #endregion


        private void FrmPaymentList_Load(object sender, EventArgs e)
        {
            LoadPayments();

            var paymentTypes = db.PaymentType.ToList();
            paymentTypes.Insert(0, new PaymentType());

            cmbPaymentType.DataSource = paymentTypes;
            cmbPaymentType.DisplayMember = "PaymentTypeName";
            cmbPaymentType.ValueMember = "PaymentTypeID";

            splitContainer1.Panel1Collapsed = true;
            toolStripButtonSummary.Checked = Properties.Settings.Default.ShowSummaryInPayments;
            splitContainer2.Panel1Collapsed = !Properties.Settings.Default.ShowSummaryInPayments;

        }

        #region toolstrip buttons

        private void ToolStripButtonSummary_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !toolStripButtonSummary.Checked;

            Properties.Settings.Default.ShowSummaryInPayments = toolStripButtonSummary.Checked;
            Properties.Settings.Default.Save();
        }

        private void ToolStripButtonFilter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !toolStripButtonFilter.Checked;
        }

        private void ÖzetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgSummary, "Özet.xlsx");
            excelHelper.ShowDialog();
        }

        private void İşlemlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgPaymentList, "İşlem Listesi.xlsx");
            excelHelper.ShowDialog();
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPaymentList.SelectedRows.Count > 0)
                {
                    int paymentID = int.Parse(dgPaymentList.SelectedRows[0].Cells[0].Value.ToString());

                    if (MessageHelper.AskMessage("İşlem silinsin mi?") == DialogResult.Yes)
                    {
                        Payment selectedPayment = db.Payment.Where(q => q.PaymentID == paymentID).FirstOrDefault();
                        if (selectedPayment != null)
                        {
                            db.Payment.Remove(selectedPayment);
                            int num = db.SaveChanges();

                            if (num > 0)
                            {
                                LoadPayments();

                                MessageHelper.InfoMessage("İşlem silindi!");
                            }
                            else
                            {
                                MessageHelper.InfoMessage("Hata!");
                            }
                        }
                        else
                        {
                            MessageHelper.InfoMessage("Kayıtlı işlem bulunamadı!");
                        }

                    }
                }
                else
                {
                    MessageHelper.InfoMessage("Listeden işlem seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }

        private void ToolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPaymentList.SelectedRows.Count > 0)
                {
                    int paymentID = int.Parse(dgPaymentList.SelectedRows[0].Cells[0].Value.ToString());

                    // check if it's in orderpayment

                    int countOrders = db.Payment.Where(q=>q.PaymentID == paymentID && q.IsDeleted == false).Count(x => x.Order.Count > 0);
                    if (countOrders > 0)
                    {
                        MessageBox.Show("Satış düzenleyi aç");
                    }
                    else
                    {
                        MessageBox.Show("Kasa işlem düzenleyi aç");
                    }

                }
                else
                {
                    MessageHelper.InfoMessage("Listeden işlem seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ErrorMessage(ex);
            }
        }

        #endregion
    }
}

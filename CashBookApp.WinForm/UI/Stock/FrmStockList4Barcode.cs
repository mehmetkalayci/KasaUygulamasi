﻿using CashBookApp.WinForm.Helper;
using CashBookApp.WinForm.Model;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmStockList4Barcode : BaseForm
    {
        public FrmStockList4Barcode()
        {
            InitializeComponent();
        }


        CashBookEntities db = new CashBookEntities();

        #region functions

        private void ApplyStyle2Grid()
        {
            if (Properties.Settings.Default.StockQuantityLimit.IsInt())
            {
                for (int i = 0; i < dgDataStocks.Rows.Count; i++)
                {
                    object dgval = dgDataStocks.Rows[i].Cells["Quantity"].Value;

                    if (dgval != null && int.Parse(dgval.ToString()) <= int.Parse(Properties.Settings.Default.StockQuantityLimit))
                    {
                        dgDataStocks.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        dgDataStocks.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        public void LoadStocks()
        {
            var stocks = db.Product.Where(q => q.IsDeleted == false).Select(q => new
            {
                q.ProductID,
                q.Barcode,
                q.ProductName,
                q.Price,
                q.Color,
                q.Size,
                q.Quantity,
                q.CreatedAt
            }).OrderByDescending(q => q.ProductID).ToList();

            dgDataStocks.DataSource = stocks;
            toolStripStatusLabelStockQuantity.Text = string.Format("{0} adet stok", stocks.Count);

            dgDataStocks.Columns[0].Visible = false;
            dgDataStocks.Columns[0].HeaderText = "Stok ID";
            dgDataStocks.Columns[1].HeaderText = "Barkod";
            dgDataStocks.Columns[2].HeaderText = "Ürün Adı";
            dgDataStocks.Columns[3].HeaderText = "Fiyat";
            dgDataStocks.Columns[4].HeaderText = "Renk";
            dgDataStocks.Columns[5].HeaderText = "Numara";
            dgDataStocks.Columns[6].HeaderText = "Adet";
            dgDataStocks.Columns[7].HeaderText = "Eklenme Tarihi";
        }

        public void LoadFilter()
        {
            var stocks = db.Product.Where(q => q.IsDeleted == false).Select(q => new
            {
                q.ProductID,
                q.Barcode,
                q.ProductName,
                q.Price,
                q.Color,
                q.Size,
                q.Quantity,
                q.CreatedAt
            }).AsQueryable();

            if (txtBarcode.Text.Trim().Length > 0)
            {
                stocks = stocks.Where(q => q.Barcode.ToString().ToLower().Contains(txtBarcode.Text.ToLower()));
            }
            if (txtProductName.Text.Trim().Length > 0)
            {
                stocks = stocks.Where(q => q.ProductName.ToString().ToLower().Contains(txtProductName.Text.ToLower()));
            }
            if (txtColor.Text.Trim().Length > 0)
            {
                stocks = stocks.Where(q => q.Color.ToString().ToLower().Contains(txtColor.Text.ToLower()));
            }
            if (txtSize.Text.Trim().Length > 0)
            {
                stocks = stocks.Where(q => q.Size.ToString().ToLower().Contains(txtSize.Text.ToLower()));
            }
            if (chkMore.Checked)
            {
                stocks = stocks.Where(q => q.Quantity >= nmMore.Value);
            }
            if (chkLess.Checked)
            {
                stocks = stocks.Where(q => q.Quantity <= nmLess.Value);
            }

            if (dtCreatedAtAfter.Checked)
            {
                stocks = stocks.Where(q => q.CreatedAt >= dtCreatedAtAfter.Value);
            }
            if (dtCreatedAtBefore.Checked)
            {
                stocks = stocks.Where(q => q.CreatedAt <= dtCreatedAtBefore.Value);
            }



            var filteredStocks = stocks.OrderByDescending(q => q.ProductID).ToList();

            dgDataStocks.DataSource = filteredStocks;
            toolStripStatusLabelStockQuantity.Text = string.Format("{0} adet stok", filteredStocks.Count);

            dgDataStocks.Columns[0].Visible = false;
            dgDataStocks.Columns[0].HeaderText = "Stok ID";
            dgDataStocks.Columns[1].HeaderText = "Barkod";
            dgDataStocks.Columns[2].HeaderText = "Ürün Adı";
            dgDataStocks.Columns[3].HeaderText = "Fiyat";
            dgDataStocks.Columns[4].HeaderText = "Renk";
            dgDataStocks.Columns[5].HeaderText = "Numara";
            dgDataStocks.Columns[6].HeaderText = "Adet";
            dgDataStocks.Columns[7].HeaderText = "Eklenme Tarihi";
        }

        void CleanFilter()
        {
            txtBarcode.Text = txtProductName.Text = txtColor.Text = txtSize.Text = "";

            dtCreatedAtAfter.Checked = dtCreatedAtBefore.Checked = chkMore.Checked = chkLess.Checked = false;

            dtCreatedAtAfter.Value = dtCreatedAtBefore.Value = DateTime.Now;

            nmMore.Value = nmLess.Value;

            LoadStocks();
        }


        void LoadBarcodes2Viewer()
        {
            List<Product> selecteds = db.Product.Where(item => IDs.Contains(item.ProductID)).ToList();

            ReportDataSource datasource = new ReportDataSource("DataSet1", selecteds);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }


        #endregion

        #region toolstrip işlemler


        private void ToolStripButtonFilter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !toolStripButtonFilter.Checked;
        }


        private void ToolStripTextBoxStockQuantityLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (toolStripTextBoxStockQuantityLimit.Text.Trim() != "" && toolStripTextBoxStockQuantityLimit.Text.Trim().IsInt())
                {
                    Properties.Settings.Default.StockQuantityLimit = toolStripTextBoxStockQuantityLimit.Text.Trim();
                    Properties.Settings.Default.Save();

                    ApplyStyle2Grid();
                }
            }
        }



        #endregion

        #region filters

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoadFilter();
            }
        }

        private void ChkMore_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void NmMore_ValueChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CleanFilter();
        }

        #endregion

        HashSet<int> IDs = new HashSet<int>();



        private void FrmStockList_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            LoadStocks();

        }

        private void DgDataStocks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgDataStocks.SelectedRows[0].Cells[0].Value.ToString());
            if (IDs.Contains(id))
            {
                IDs.Remove(id);
                dgDataStocks.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                IDs.Add(id);
                dgDataStocks.SelectedRows[0].DefaultCellStyle.BackColor = Color.DarkOrchid;
            }
            LoadBarcodes2Viewer();
        }

        private void SeçilenleriİşaretleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDataStocks.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgDataStocks.SelectedRows.Count; i++)
                {
                    int id = int.Parse(dgDataStocks.SelectedRows[i].Cells[0].Value.ToString());
                    IDs.Add(id);
                    dgDataStocks.SelectedRows[i].DefaultCellStyle.BackColor = Color.DarkOrchid;
                }
                LoadBarcodes2Viewer();
            }
        }

        private void SeçilenlerinİşaretiniKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgDataStocks.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgDataStocks.SelectedRows.Count; i++)
                {
                    int id = int.Parse(dgDataStocks.SelectedRows[i].Cells[0].Value.ToString());
                    IDs.Remove(id);
                    dgDataStocks.SelectedRows[i].DefaultCellStyle.BackColor = Color.White;
                }
                LoadBarcodes2Viewer();
            }
        }

    }
}

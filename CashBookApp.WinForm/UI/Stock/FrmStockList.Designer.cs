namespace CashBookApp.WinForm.UI.Stock
{
    partial class FrmStockList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.dtCreatedAtBefore = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtCreatedAtAfter = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.chkLess = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkMore = new MetroFramework.Controls.MetroCheckBox();
            this.txtSize = new MetroFramework.Controls.MetroTextBox();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.nmLess = new System.Windows.Forms.NumericUpDown();
            this.nmMore = new System.Windows.Forms.NumericUpDown();
            this.dgDataStocks = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxStockQuantityLimit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonBarcodeForm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStockQuantity = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataStocks)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.dtCreatedAtBefore);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer1.Panel1.Controls.Add(this.dtCreatedAtAfter);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel7);
            this.splitContainer1.Panel1.Controls.Add(this.chkLess);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel6);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.chkMore);
            this.splitContainer1.Panel1.Controls.Add(this.txtSize);
            this.splitContainer1.Panel1.Controls.Add(this.txtColor);
            this.splitContainer1.Panel1.Controls.Add(this.txtProductName);
            this.splitContainer1.Panel1.Controls.Add(this.txtBarcode);
            this.splitContainer1.Panel1.Controls.Add(this.nmLess);
            this.splitContainer1.Panel1.Controls.Add(this.nmMore);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDataStocks);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(109, 438);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dtCreatedAtBefore
            // 
            this.dtCreatedAtBefore.Checked = false;
            this.dtCreatedAtBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedAtBefore.Location = new System.Drawing.Point(14, 403);
            this.dtCreatedAtBefore.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCreatedAtBefore.Name = "dtCreatedAtBefore";
            this.dtCreatedAtBefore.ShowCheckBox = true;
            this.dtCreatedAtBefore.Size = new System.Drawing.Size(170, 29);
            this.dtCreatedAtBefore.TabIndex = 16;
            this.dtCreatedAtBefore.ValueChanged += new System.EventHandler(this.NmMore_ValueChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(14, 381);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Ürün Kayıt Tarihi, Bitiş";
            this.metroLabel8.WrapToLine = true;
            // 
            // dtCreatedAtAfter
            // 
            this.dtCreatedAtAfter.Checked = false;
            this.dtCreatedAtAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedAtAfter.Location = new System.Drawing.Point(14, 349);
            this.dtCreatedAtAfter.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCreatedAtAfter.Name = "dtCreatedAtAfter";
            this.dtCreatedAtAfter.ShowCheckBox = true;
            this.dtCreatedAtAfter.Size = new System.Drawing.Size(170, 29);
            this.dtCreatedAtAfter.TabIndex = 14;
            this.dtCreatedAtAfter.ValueChanged += new System.EventHandler(this.NmMore_ValueChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 327);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(163, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Ürün Kayıt Tarihi, Başlangıç";
            this.metroLabel7.WrapToLine = true;
            // 
            // chkLess
            // 
            this.chkLess.AutoSize = true;
            this.chkLess.Location = new System.Drawing.Point(14, 283);
            this.chkLess.Name = "chkLess";
            this.chkLess.Size = new System.Drawing.Size(108, 15);
            this.chkLess.TabIndex = 11;
            this.chkLess.Text = "Stok Adedi, Bitiş";
            this.chkLess.UseSelectable = true;
            this.chkLess.CheckedChanged += new System.EventHandler(this.ChkMore_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 185);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Numara";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 137);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Renk";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(167, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Arama kriterlerini belirleyin";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Ürün Adı";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Barkod";
            // 
            // chkMore
            // 
            this.chkMore.AutoSize = true;
            this.chkMore.Location = new System.Drawing.Point(14, 236);
            this.chkMore.Name = "chkMore";
            this.chkMore.Size = new System.Drawing.Size(136, 15);
            this.chkMore.TabIndex = 9;
            this.chkMore.Text = "Stok Adedi, Başlangıç";
            this.chkMore.UseSelectable = true;
            this.chkMore.CheckedChanged += new System.EventHandler(this.ChkMore_CheckedChanged);
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.CustomButton.Image = null;
            this.txtSize.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtSize.CustomButton.Name = "";
            this.txtSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSize.CustomButton.TabIndex = 1;
            this.txtSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSize.CustomButton.UseSelectable = true;
            this.txtSize.CustomButton.Visible = false;
            this.txtSize.Lines = new string[0];
            this.txtSize.Location = new System.Drawing.Point(14, 207);
            this.txtSize.MaxLength = 32767;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.ShortcutsEnabled = true;
            this.txtSize.Size = new System.Drawing.Size(170, 23);
            this.txtSize.TabIndex = 8;
            this.txtSize.UseSelectable = true;
            this.txtSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.CustomButton.Image = null;
            this.txtColor.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtColor.CustomButton.Name = "";
            this.txtColor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColor.CustomButton.TabIndex = 1;
            this.txtColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColor.CustomButton.UseSelectable = true;
            this.txtColor.CustomButton.Visible = false;
            this.txtColor.Lines = new string[0];
            this.txtColor.Location = new System.Drawing.Point(14, 159);
            this.txtColor.MaxLength = 32767;
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColor.SelectedText = "";
            this.txtColor.SelectionLength = 0;
            this.txtColor.SelectionStart = 0;
            this.txtColor.ShortcutsEnabled = true;
            this.txtColor.Size = new System.Drawing.Size(170, 23);
            this.txtColor.TabIndex = 6;
            this.txtColor.UseSelectable = true;
            this.txtColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(14, 111);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(170, 23);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(14, 63);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(170, 23);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // nmLess
            // 
            this.nmLess.Location = new System.Drawing.Point(14, 304);
            this.nmLess.Name = "nmLess";
            this.nmLess.Size = new System.Drawing.Size(170, 20);
            this.nmLess.TabIndex = 12;
            this.nmLess.ValueChanged += new System.EventHandler(this.NmMore_ValueChanged);
            // 
            // nmMore
            // 
            this.nmMore.Location = new System.Drawing.Point(14, 257);
            this.nmMore.Name = "nmMore";
            this.nmMore.Size = new System.Drawing.Size(170, 20);
            this.nmMore.TabIndex = 10;
            this.nmMore.ValueChanged += new System.EventHandler(this.NmMore_ValueChanged);
            // 
            // dgDataStocks
            // 
            this.dgDataStocks.AllowUserToAddRows = false;
            this.dgDataStocks.AllowUserToDeleteRows = false;
            this.dgDataStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDataStocks.BackgroundColor = System.Drawing.Color.White;
            this.dgDataStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDataStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDataStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataStocks.Location = new System.Drawing.Point(0, 29);
            this.dgDataStocks.MultiSelect = false;
            this.dgDataStocks.Name = "dgDataStocks";
            this.dgDataStocks.ReadOnly = true;
            this.dgDataStocks.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataStocks.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDataStocks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDataStocks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDataStocks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgDataStocks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataStocks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDataStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDataStocks.Size = new System.Drawing.Size(855, 567);
            this.dgDataStocks.TabIndex = 1;
            this.dgDataStocks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDataStocks_CellContentDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonDelete,
            this.toolStripButtonUpdate,
            this.toolStripButtonFilter,
            this.toolStripSeparator1,
            this.toolStripButtonExcel,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBoxStockQuantityLimit,
            this.toolStripButtonBarcodeForm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(855, 29);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::CashBookApp.WinForm.Properties.Resources.add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonAdd.Size = new System.Drawing.Size(68, 20);
            this.toolStripButtonAdd.Text = "Ekle";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAdd_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = global::CashBookApp.WinForm.Properties.Resources.delete;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonDelete.Size = new System.Drawing.Size(59, 20);
            this.toolStripButtonDelete.Text = "Sil";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDelete_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.Image = global::CashBookApp.WinForm.Properties.Resources.edit;
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(93, 20);
            this.toolStripButtonUpdate.Text = "Güncelle";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.ToolStripButtonUpdate_Click);
            // 
            // toolStripButtonFilter
            // 
            this.toolStripButtonFilter.CheckOnClick = true;
            this.toolStripButtonFilter.Image = global::CashBookApp.WinForm.Properties.Resources.filter;
            this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter.Name = "toolStripButtonFilter";
            this.toolStripButtonFilter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonFilter.Size = new System.Drawing.Size(82, 20);
            this.toolStripButtonFilter.Text = "Filtrele";
            this.toolStripButtonFilter.Click += new System.EventHandler(this.ToolStripButtonFilter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonExcel
            // 
            this.toolStripButtonExcel.Image = global::CashBookApp.WinForm.Properties.Resources.excel;
            this.toolStripButtonExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcel.Name = "toolStripButtonExcel";
            this.toolStripButtonExcel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonExcel.Size = new System.Drawing.Size(114, 20);
            this.toolStripButtonExcel.Text = "Excel\'e Aktar";
            this.toolStripButtonExcel.Click += new System.EventHandler(this.ToolStripButtonExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 20);
            this.toolStripLabel1.Text = "Stok Limit: ";
            // 
            // toolStripTextBoxStockQuantityLimit
            // 
            this.toolStripTextBoxStockQuantityLimit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxStockQuantityLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxStockQuantityLimit.MaxLength = 5;
            this.toolStripTextBoxStockQuantityLimit.Name = "toolStripTextBoxStockQuantityLimit";
            this.toolStripTextBoxStockQuantityLimit.Size = new System.Drawing.Size(75, 23);
            this.toolStripTextBoxStockQuantityLimit.Text = global::CashBookApp.WinForm.Properties.Settings.Default.StockQuantityLimit;
            this.toolStripTextBoxStockQuantityLimit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBoxStockQuantityLimit.ToolTipText = "Stok limitini girip Enter tuşuyla onaylayın, otomatik olarak kaydedilecek.\r\nGiril" +
    "en limitin altındaki ürünler renkli gösterilecek.";
            this.toolStripTextBoxStockQuantityLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBoxStockQuantityLimit_KeyDown);
            // 
            // toolStripButtonBarcodeForm
            // 
            this.toolStripButtonBarcodeForm.Image = global::CashBookApp.WinForm.Properties.Resources.barcode;
            this.toolStripButtonBarcodeForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBarcodeForm.Name = "toolStripButtonBarcodeForm";
            this.toolStripButtonBarcodeForm.Size = new System.Drawing.Size(103, 20);
            this.toolStripButtonBarcodeForm.Text = "Barkod Hazırla";
            this.toolStripButtonBarcodeForm.Visible = false;
            this.toolStripButtonBarcodeForm.Click += new System.EventHandler(this.ToolStripButtonBarcodeForm_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStockQuantity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(855, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabelStockQuantity
            // 
            this.toolStripStatusLabelStockQuantity.Name = "toolStripStatusLabelStockQuantity";
            this.toolStripStatusLabelStockQuantity.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelStockQuantity.Text = "...";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FrmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmStockList";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.FrmStockList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmLess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataStocks)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroDateTime dtCreatedAtBefore;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtCreatedAtAfter;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox chkLess;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkMore;
        private MetroFramework.Controls.MetroTextBox txtSize;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private System.Windows.Forms.NumericUpDown nmLess;
        private System.Windows.Forms.NumericUpDown nmMore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStockQuantityLimit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStockQuantity;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridView dgDataStocks;
        private System.Windows.Forms.ToolStripButton toolStripButtonBarcodeForm;
    }
}
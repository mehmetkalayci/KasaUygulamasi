namespace CashBookApp.WinForm.UI.Sales
{
    partial class FrmSalesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.dtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgDataOrders = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgDataOrderDetails = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountOrderDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataOrders)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataOrderDetails)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.dtEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer1.Panel1.Controls.Add(this.dtStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel7);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel9);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel10);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerPhone);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerName);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(109, 248);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 38;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 248);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Checked = false;
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(14, 213);
            this.dtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.ShowCheckBox = true;
            this.dtEndDate.Size = new System.Drawing.Size(170, 29);
            this.dtEndDate.TabIndex = 37;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.DtStartDate_ValueChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(14, 191);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Bitiş Tarihi";
            this.metroLabel8.WrapToLine = true;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Checked = false;
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(14, 159);
            this.dtStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ShowCheckBox = true;
            this.dtStartDate.Size = new System.Drawing.Size(170, 29);
            this.dtStartDate.TabIndex = 35;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.DtStartDate_ValueChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 137);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Başlangıç Tarihi";
            this.metroLabel7.WrapToLine = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(14, 89);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(97, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Müşteri Telefon";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(14, 41);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(113, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Müşteri Ad Soyad";
            // 
            // txtCustomerPhone
            // 
            // 
            // 
            // 
            this.txtCustomerPhone.CustomButton.Image = null;
            this.txtCustomerPhone.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtCustomerPhone.CustomButton.Name = "";
            this.txtCustomerPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerPhone.CustomButton.TabIndex = 1;
            this.txtCustomerPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerPhone.CustomButton.UseSelectable = true;
            this.txtCustomerPhone.CustomButton.Visible = false;
            this.txtCustomerPhone.Lines = new string[0];
            this.txtCustomerPhone.Location = new System.Drawing.Point(14, 111);
            this.txtCustomerPhone.MaxLength = 32767;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.PasswordChar = '\0';
            this.txtCustomerPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerPhone.SelectedText = "";
            this.txtCustomerPhone.SelectionLength = 0;
            this.txtCustomerPhone.SelectionStart = 0;
            this.txtCustomerPhone.ShortcutsEnabled = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(170, 23);
            this.txtCustomerPhone.TabIndex = 25;
            this.txtCustomerPhone.UseSelectable = true;
            this.txtCustomerPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(14, 63);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(170, 23);
            this.txtCustomerName.TabIndex = 23;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
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
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::CashBookApp.WinForm.Properties.Settings.Default, "SalesListSplitter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 29);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgDataOrders);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgDataOrderDetails);
            this.splitContainer2.Panel2.Controls.Add(this.metroLabel5);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(857, 591);
            this.splitContainer2.SplitterDistance = global::CashBookApp.WinForm.Properties.Settings.Default.SalesListSplitter;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 4;
            // 
            // dgDataOrders
            // 
            this.dgDataOrders.AllowUserToAddRows = false;
            this.dgDataOrders.AllowUserToDeleteRows = false;
            this.dgDataOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDataOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgDataOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDataOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataOrders.Location = new System.Drawing.Point(0, 19);
            this.dgDataOrders.MultiSelect = false;
            this.dgDataOrders.Name = "dgDataOrders";
            this.dgDataOrders.ReadOnly = true;
            this.dgDataOrders.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataOrders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDataOrders.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDataOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDataOrders.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgDataOrders.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDataOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDataOrders.Size = new System.Drawing.Size(498, 548);
            this.dgDataOrders.TabIndex = 9;
            this.dgDataOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDataOrders_CellContentDoubleClick);
            this.dgDataOrders.SelectionChanged += new System.EventHandler(this.DgDataOrders_SelectionChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(498, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Satış Listesi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountOrders});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(498, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            // 
            // toolStripStatusLabelCountOrders
            // 
            this.toolStripStatusLabelCountOrders.Name = "toolStripStatusLabelCountOrders";
            this.toolStripStatusLabelCountOrders.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelCountOrders.Text = "...";
            // 
            // dgDataOrderDetails
            // 
            this.dgDataOrderDetails.AllowUserToAddRows = false;
            this.dgDataOrderDetails.AllowUserToDeleteRows = false;
            this.dgDataOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDataOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgDataOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDataOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDataOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataOrderDetails.Location = new System.Drawing.Point(0, 19);
            this.dgDataOrderDetails.MultiSelect = false;
            this.dgDataOrderDetails.Name = "dgDataOrderDetails";
            this.dgDataOrderDetails.ReadOnly = true;
            this.dgDataOrderDetails.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDataOrderDetails.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDataOrderDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDataOrderDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgDataOrderDetails.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataOrderDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDataOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDataOrderDetails.Size = new System.Drawing.Size(350, 548);
            this.dgDataOrderDetails.TabIndex = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(350, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Satış Detayları";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountOrderDetails});
            this.statusStrip2.Location = new System.Drawing.Point(0, 567);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.Size = new System.Drawing.Size(350, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 7;
            // 
            // toolStripStatusLabelCountOrderDetails
            // 
            this.toolStripStatusLabelCountOrderDetails.Name = "toolStripStatusLabelCountOrderDetails";
            this.toolStripStatusLabelCountOrderDetails.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelCountOrderDetails.Text = "...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDelete,
            this.toolStripButtonUpdate,
            this.toolStripButtonFilter,
            this.toolStripSeparator1,
            this.toolStripButtonExcel,
            this.toolStripSeparator2,
            this.toolStripButtonReturn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(857, 29);
            this.toolStrip1.TabIndex = 3;
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
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.Image = global::CashBookApp.WinForm.Properties.Resources._return;
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(96, 20);
            this.toolStripButtonReturn.Text = "İade İşlemleri";
            this.toolStripButtonReturn.Click += new System.EventHandler(this.ToolStripButtonReturn_Click);
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSalesList";
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.FrmSalesList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDataOrders)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataOrderDetails)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountOrderDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountOrders;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgDataOrderDetails;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcel;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroDateTime dtEndDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtCustomerPhone;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.DataGridView dgDataOrders;
    }
}
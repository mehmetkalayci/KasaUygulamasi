namespace CashBookApp.WinForm.UI.CashBook
{
    partial class FrmPaymentList
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.btnClean = new MetroFramework.Controls.MetroButton();
            this.chkExpenses = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.cmbPaymentType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtTransactionTimeEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtTransactionTimeStart = new MetroFramework.Controls.MetroDateTime();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgSummary = new System.Windows.Forms.DataGridView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSummary = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dgPaymentList = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripSplitButton();
            this.özetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSummary = new System.Windows.Forms.ToolStripButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTransactionCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentList)).BeginInit();
            this.toolStrip2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
            this.splitContainer1.Panel1.Controls.Add(this.btnClean);
            this.splitContainer1.Panel1.Controls.Add(this.chkExpenses);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescription);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPaymentType);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.dtTransactionTimeEnd);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.dtTransactionTimeStart);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(167, 19);
            this.metroLabel5.TabIndex = 67;
            this.metroLabel5.Text = "Arama kriterlerini belirleyin";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(109, 277);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 66;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(14, 277);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 66;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseSelectable = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // chkExpenses
            // 
            this.chkExpenses.AutoSize = true;
            this.chkExpenses.Location = new System.Drawing.Point(14, 256);
            this.chkExpenses.Name = "chkExpenses";
            this.chkExpenses.Size = new System.Drawing.Size(104, 15);
            this.chkExpenses.TabIndex = 65;
            this.chkExpenses.Text = "Sadece Giderler";
            this.chkExpenses.UseSelectable = true;
            this.chkExpenses.CheckedChanged += new System.EventHandler(this.ChkExpenses_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Açıklama";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(14, 227);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(170, 23);
            this.txtDescription.TabIndex = 63;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.ItemHeight = 23;
            this.cmbPaymentType.Location = new System.Drawing.Point(14, 173);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(170, 29);
            this.cmbPaymentType.TabIndex = 62;
            this.cmbPaymentType.UseSelectable = true;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.CmbPaymentType_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Ödeme Tipi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "Bitiş Tarihi";
            // 
            // dtTransactionTimeEnd
            // 
            this.dtTransactionTimeEnd.Checked = false;
            this.dtTransactionTimeEnd.Location = new System.Drawing.Point(14, 119);
            this.dtTransactionTimeEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTransactionTimeEnd.Name = "dtTransactionTimeEnd";
            this.dtTransactionTimeEnd.ShowCheckBox = true;
            this.dtTransactionTimeEnd.Size = new System.Drawing.Size(170, 29);
            this.dtTransactionTimeEnd.TabIndex = 59;
            this.dtTransactionTimeEnd.ValueChanged += new System.EventHandler(this.DtTransactionTimeEnd_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Başlangıç Tarihi";
            // 
            // dtTransactionTimeStart
            // 
            this.dtTransactionTimeStart.Checked = false;
            this.dtTransactionTimeStart.Location = new System.Drawing.Point(14, 65);
            this.dtTransactionTimeStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTransactionTimeStart.Name = "dtTransactionTimeStart";
            this.dtTransactionTimeStart.ShowCheckBox = true;
            this.dtTransactionTimeStart.Size = new System.Drawing.Size(170, 29);
            this.dtTransactionTimeStart.TabIndex = 57;
            this.dtTransactionTimeStart.ValueChanged += new System.EventHandler(this.DtTransactionTimeEnd_ValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::CashBookApp.WinForm.Properties.Settings.Default, "SummarySplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgSummary);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip2);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgPaymentList);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel2.Controls.Add(this.metroLabel7);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(857, 620);
            this.splitContainer2.SplitterDistance = global::CashBookApp.WinForm.Properties.Settings.Default.SummarySplitterDistance;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 27;
            // 
            // dgSummary
            // 
            this.dgSummary.AllowUserToAddRows = false;
            this.dgSummary.AllowUserToDeleteRows = false;
            this.dgSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSummary.Location = new System.Drawing.Point(0, 25);
            this.dgSummary.MultiSelect = false;
            this.dgSummary.Name = "dgSummary";
            this.dgSummary.ReadOnly = true;
            this.dgSummary.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgSummary.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSummary.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSummary.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSummary.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgSummary.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgSummary.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummary.Size = new System.Drawing.Size(855, 101);
            this.dgSummary.TabIndex = 76;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSummary});
            this.statusStrip2.Location = new System.Drawing.Point(0, 126);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.Size = new System.Drawing.Size(855, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 75;
            // 
            // toolStripStatusLabelSummary
            // 
            this.toolStripStatusLabelSummary.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelSummary.Name = "toolStripStatusLabelSummary";
            this.toolStripStatusLabelSummary.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelSummary.Text = "...";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel8.Location = new System.Drawing.Point(0, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(855, 25);
            this.metroLabel8.TabIndex = 73;
            this.metroLabel8.Text = "Özet";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgPaymentList
            // 
            this.dgPaymentList.AllowUserToAddRows = false;
            this.dgPaymentList.AllowUserToDeleteRows = false;
            this.dgPaymentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPaymentList.BackgroundColor = System.Drawing.Color.White;
            this.dgPaymentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPaymentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPaymentList.Location = new System.Drawing.Point(0, 54);
            this.dgPaymentList.MultiSelect = false;
            this.dgPaymentList.Name = "dgPaymentList";
            this.dgPaymentList.ReadOnly = true;
            this.dgPaymentList.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPaymentList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPaymentList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPaymentList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPaymentList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgPaymentList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPaymentList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPaymentList.Size = new System.Drawing.Size(855, 389);
            this.dgPaymentList.TabIndex = 75;
            this.dgPaymentList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPaymentList_CellContentDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDelete,
            this.toolStripButtonUpdate,
            this.toolStripButtonFilter,
            this.toolStripSeparator3,
            this.toolStripButtonExcel,
            this.toolStripSeparator4,
            this.toolStripButtonSummary});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(855, 29);
            this.toolStrip2.TabIndex = 74;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonExcel
            // 
            this.toolStripButtonExcel.BackColor = System.Drawing.Color.White;
            this.toolStripButtonExcel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özetToolStripMenuItem1,
            this.işlemlerToolStripMenuItem1});
            this.toolStripButtonExcel.Image = global::CashBookApp.WinForm.Properties.Resources.excel;
            this.toolStripButtonExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcel.Name = "toolStripButtonExcel";
            this.toolStripButtonExcel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButtonExcel.Size = new System.Drawing.Size(126, 20);
            this.toolStripButtonExcel.Text = "Excel\'e Aktar";
            // 
            // özetToolStripMenuItem1
            // 
            this.özetToolStripMenuItem1.Name = "özetToolStripMenuItem1";
            this.özetToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.özetToolStripMenuItem1.Text = "Özet";
            this.özetToolStripMenuItem1.Click += new System.EventHandler(this.ÖzetToolStripMenuItem1_Click);
            // 
            // işlemlerToolStripMenuItem1
            // 
            this.işlemlerToolStripMenuItem1.Name = "işlemlerToolStripMenuItem1";
            this.işlemlerToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.işlemlerToolStripMenuItem1.Text = "İşlemler";
            this.işlemlerToolStripMenuItem1.Click += new System.EventHandler(this.İşlemlerToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonSummary
            // 
            this.toolStripButtonSummary.Checked = global::CashBookApp.WinForm.Properties.Settings.Default.ShowSummaryInPayments;
            this.toolStripButtonSummary.CheckOnClick = true;
            this.toolStripButtonSummary.Image = global::CashBookApp.WinForm.Properties.Resources.summary;
            this.toolStripButtonSummary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSummary.Name = "toolStripButtonSummary";
            this.toolStripButtonSummary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonSummary.Size = new System.Drawing.Size(70, 20);
            this.toolStripButtonSummary.Text = "Özetle";
            this.toolStripButtonSummary.Click += new System.EventHandler(this.ToolStripButtonSummary_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel7.Location = new System.Drawing.Point(0, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(855, 25);
            this.metroLabel7.TabIndex = 72;
            this.metroLabel7.Text = "İşlemler";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTransactionCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(855, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 71;
            // 
            // toolStripStatusLabelTransactionCount
            // 
            this.toolStripStatusLabelTransactionCount.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelTransactionCount.Name = "toolStripStatusLabelTransactionCount";
            this.toolStripStatusLabelTransactionCount.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelTransactionCount.Text = "...";
            // 
            // FrmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmPaymentList";
            this.Text = "Gün Sonu";
            this.Load += new System.EventHandler(this.FrmPaymentList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroButton btnClean;
        private MetroFramework.Controls.MetroCheckBox chkExpenses;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroComboBox cmbPaymentType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtTransactionTimeEnd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtTransactionTimeStart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSummary;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTransactionCount;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonExcel;
        private System.Windows.Forms.ToolStripMenuItem özetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSummary;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridView dgSummary;
        private System.Windows.Forms.DataGridView dgPaymentList;
    }
}
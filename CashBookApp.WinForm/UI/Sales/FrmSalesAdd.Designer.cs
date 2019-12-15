namespace CashBookApp.WinForm.UI.Sales
{
    partial class FrmSalesAdd
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
            this.dgBasket = new System.Windows.Forms.DataGridView();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanelPaymentInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtPaymentVal1 = new MetroFramework.Controls.MetroTextBox();
            this.cmbPaymentType2 = new MetroFramework.Controls.MetroComboBox();
            this.cmbPaymentType1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.chkPartialPayment = new MetroFramework.Controls.MetroCheckBox();
            this.txtPaymentVal2 = new MetroFramework.Controls.MetroTextBox();
            this.txtDesc1 = new MetroFramework.Controls.MetroTextBox();
            this.txtDesc2 = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanelCustomerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtCustomerPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).BeginInit();
            this.tableLayoutPanelPaymentInfo.SuspendLayout();
            this.tableLayoutPanelCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBasket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgBasket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBasket.BackgroundColor = System.Drawing.Color.White;
            this.dgBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBasket.EnableHeadersVisualStyles = false;
            this.dgBasket.Location = new System.Drawing.Point(23, 145);
            this.dgBasket.MultiSelect = false;
            this.dgBasket.Name = "dgBasket";
            this.dgBasket.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBasket.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBasket.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgBasket.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgBasket.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgBasket.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBasket.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBasket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBasket.Size = new System.Drawing.Size(500, 392);
            this.dgBasket.TabIndex = 6;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(556, 249);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 25);
            this.metroLabel9.TabIndex = 99;
            this.metroLabel9.Text = "Müşteri";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(556, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 25);
            this.metroLabel4.TabIndex = 98;
            this.metroLabel4.Text = "Tahsilat Detay";
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Location = new System.Drawing.Point(975, 391);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 94;
            this.btnPay.Text = "Bitir";
            this.btnPay.UseSelectable = true;
            // 
            // tableLayoutPanelPaymentInfo
            // 
            this.tableLayoutPanelPaymentInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelPaymentInfo.ColumnCount = 4;
            this.tableLayoutPanelPaymentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPaymentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPaymentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPaymentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.txtPaymentVal1, 2, 1);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.cmbPaymentType2, 1, 2);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.cmbPaymentType1, 1, 1);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.metroLabel6, 0, 2);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.metroLabel3, 3, 0);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.metroLabel5, 0, 1);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.metroLabel2, 1, 0);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.metroLabel7, 2, 0);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.chkPartialPayment, 0, 0);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.txtPaymentVal2, 2, 2);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.txtDesc1, 3, 1);
            this.tableLayoutPanelPaymentInfo.Controls.Add(this.txtDesc2, 3, 2);
            this.tableLayoutPanelPaymentInfo.Location = new System.Drawing.Point(552, 114);
            this.tableLayoutPanelPaymentInfo.Name = "tableLayoutPanelPaymentInfo";
            this.tableLayoutPanelPaymentInfo.RowCount = 3;
            this.tableLayoutPanelPaymentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPaymentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPaymentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPaymentInfo.Size = new System.Drawing.Size(502, 106);
            this.tableLayoutPanelPaymentInfo.TabIndex = 96;
            // 
            // txtPaymentVal1
            // 
            // 
            // 
            // 
            this.txtPaymentVal1.CustomButton.Image = null;
            this.txtPaymentVal1.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtPaymentVal1.CustomButton.Name = "";
            this.txtPaymentVal1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaymentVal1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentVal1.CustomButton.TabIndex = 1;
            this.txtPaymentVal1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentVal1.CustomButton.UseSelectable = true;
            this.txtPaymentVal1.CustomButton.Visible = false;
            this.txtPaymentVal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaymentVal1.Lines = new string[0];
            this.txtPaymentVal1.Location = new System.Drawing.Point(254, 39);
            this.txtPaymentVal1.MaxLength = 32767;
            this.txtPaymentVal1.Name = "txtPaymentVal1";
            this.txtPaymentVal1.PasswordChar = '\0';
            this.txtPaymentVal1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentVal1.SelectedText = "";
            this.txtPaymentVal1.SelectionLength = 0;
            this.txtPaymentVal1.SelectionStart = 0;
            this.txtPaymentVal1.ShortcutsEnabled = true;
            this.txtPaymentVal1.Size = new System.Drawing.Size(118, 28);
            this.txtPaymentVal1.TabIndex = 1;
            this.txtPaymentVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentVal1.UseSelectable = true;
            this.txtPaymentVal1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentVal1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPaymentType2
            // 
            this.cmbPaymentType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPaymentType2.FormattingEnabled = true;
            this.cmbPaymentType2.ItemHeight = 23;
            this.cmbPaymentType2.Location = new System.Drawing.Point(129, 74);
            this.cmbPaymentType2.Name = "cmbPaymentType2";
            this.cmbPaymentType2.Size = new System.Drawing.Size(118, 29);
            this.cmbPaymentType2.TabIndex = 4;
            this.cmbPaymentType2.UseSelectable = true;
            // 
            // cmbPaymentType1
            // 
            this.cmbPaymentType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPaymentType1.FormattingEnabled = true;
            this.cmbPaymentType1.ItemHeight = 23;
            this.cmbPaymentType1.Location = new System.Drawing.Point(129, 39);
            this.cmbPaymentType1.Name = "cmbPaymentType1";
            this.cmbPaymentType1.Size = new System.Drawing.Size(118, 29);
            this.cmbPaymentType1.TabIndex = 0;
            this.cmbPaymentType1.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel6.Location = new System.Drawing.Point(4, 71);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 34);
            this.metroLabel6.TabIndex = 94;
            this.metroLabel6.Text = "Tahsilat #2";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.Location = new System.Drawing.Point(379, 1);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 34);
            this.metroLabel3.TabIndex = 93;
            this.metroLabel3.Text = "İşlem Açıklaması";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.Location = new System.Drawing.Point(4, 36);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 34);
            this.metroLabel5.TabIndex = 93;
            this.metroLabel5.Text = "Tahsilat #1";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.Location = new System.Drawing.Point(129, 1);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 34);
            this.metroLabel2.TabIndex = 92;
            this.metroLabel2.Text = "Ödeme Tipi Seçin";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel7.Location = new System.Drawing.Point(254, 1);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(118, 34);
            this.metroLabel7.TabIndex = 92;
            this.metroLabel7.Text = "Tutar (₺)";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPartialPayment
            // 
            this.chkPartialPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPartialPayment.Location = new System.Drawing.Point(4, 4);
            this.chkPartialPayment.Name = "chkPartialPayment";
            this.chkPartialPayment.Size = new System.Drawing.Size(118, 28);
            this.chkPartialPayment.TabIndex = 3;
            this.chkPartialPayment.Text = "Parsiyel Mi?";
            this.chkPartialPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPartialPayment.UseSelectable = true;
            // 
            // txtPaymentVal2
            // 
            // 
            // 
            // 
            this.txtPaymentVal2.CustomButton.Image = null;
            this.txtPaymentVal2.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtPaymentVal2.CustomButton.Name = "";
            this.txtPaymentVal2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaymentVal2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentVal2.CustomButton.TabIndex = 1;
            this.txtPaymentVal2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentVal2.CustomButton.UseSelectable = true;
            this.txtPaymentVal2.CustomButton.Visible = false;
            this.txtPaymentVal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaymentVal2.Lines = new string[0];
            this.txtPaymentVal2.Location = new System.Drawing.Point(254, 74);
            this.txtPaymentVal2.MaxLength = 32767;
            this.txtPaymentVal2.Name = "txtPaymentVal2";
            this.txtPaymentVal2.PasswordChar = '\0';
            this.txtPaymentVal2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentVal2.SelectedText = "";
            this.txtPaymentVal2.SelectionLength = 0;
            this.txtPaymentVal2.SelectionStart = 0;
            this.txtPaymentVal2.ShortcutsEnabled = true;
            this.txtPaymentVal2.Size = new System.Drawing.Size(118, 28);
            this.txtPaymentVal2.TabIndex = 5;
            this.txtPaymentVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentVal2.UseSelectable = true;
            this.txtPaymentVal2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentVal2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDesc1
            // 
            // 
            // 
            // 
            this.txtDesc1.CustomButton.Image = null;
            this.txtDesc1.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtDesc1.CustomButton.Name = "";
            this.txtDesc1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDesc1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc1.CustomButton.TabIndex = 1;
            this.txtDesc1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc1.CustomButton.UseSelectable = true;
            this.txtDesc1.CustomButton.Visible = false;
            this.txtDesc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc1.Lines = new string[0];
            this.txtDesc1.Location = new System.Drawing.Point(379, 39);
            this.txtDesc1.MaxLength = 1024;
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.PasswordChar = '\0';
            this.txtDesc1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc1.SelectedText = "";
            this.txtDesc1.SelectionLength = 0;
            this.txtDesc1.SelectionStart = 0;
            this.txtDesc1.ShortcutsEnabled = true;
            this.txtDesc1.Size = new System.Drawing.Size(119, 28);
            this.txtDesc1.TabIndex = 2;
            this.txtDesc1.UseSelectable = true;
            this.txtDesc1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDesc2
            // 
            // 
            // 
            // 
            this.txtDesc2.CustomButton.Image = null;
            this.txtDesc2.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtDesc2.CustomButton.Name = "";
            this.txtDesc2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDesc2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc2.CustomButton.TabIndex = 1;
            this.txtDesc2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc2.CustomButton.UseSelectable = true;
            this.txtDesc2.CustomButton.Visible = false;
            this.txtDesc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc2.Lines = new string[0];
            this.txtDesc2.Location = new System.Drawing.Point(379, 74);
            this.txtDesc2.MaxLength = 32767;
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.PasswordChar = '\0';
            this.txtDesc2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc2.SelectedText = "";
            this.txtDesc2.SelectionLength = 0;
            this.txtDesc2.SelectionStart = 0;
            this.txtDesc2.ShortcutsEnabled = true;
            this.txtDesc2.Size = new System.Drawing.Size(119, 28);
            this.txtDesc2.TabIndex = 6;
            this.txtDesc2.UseSelectable = true;
            this.txtDesc2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanelCustomerInfo
            // 
            this.tableLayoutPanelCustomerInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelCustomerInfo.ColumnCount = 2;
            this.tableLayoutPanelCustomerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCustomerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelCustomerInfo.Controls.Add(this.cmbCustomer, 1, 0);
            this.tableLayoutPanelCustomerInfo.Controls.Add(this.txtCustomerPhone, 1, 1);
            this.tableLayoutPanelCustomerInfo.Controls.Add(this.metroLabel8, 0, 0);
            this.tableLayoutPanelCustomerInfo.Controls.Add(this.metroLabel10, 0, 1);
            this.tableLayoutPanelCustomerInfo.Location = new System.Drawing.Point(552, 277);
            this.tableLayoutPanelCustomerInfo.Name = "tableLayoutPanelCustomerInfo";
            this.tableLayoutPanelCustomerInfo.RowCount = 2;
            this.tableLayoutPanelCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCustomerInfo.Size = new System.Drawing.Size(505, 74);
            this.tableLayoutPanelCustomerInfo.TabIndex = 97;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.BackColor = System.Drawing.Color.White;
            this.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(130, 4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(371, 21);
            this.cmbCustomer.TabIndex = 0;
            // 
            // txtCustomerPhone
            // 
            // 
            // 
            // 
            this.txtCustomerPhone.CustomButton.Image = null;
            this.txtCustomerPhone.CustomButton.Location = new System.Drawing.Point(343, 2);
            this.txtCustomerPhone.CustomButton.Name = "";
            this.txtCustomerPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCustomerPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerPhone.CustomButton.TabIndex = 1;
            this.txtCustomerPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerPhone.CustomButton.UseSelectable = true;
            this.txtCustomerPhone.CustomButton.Visible = false;
            this.txtCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerPhone.Lines = new string[0];
            this.txtCustomerPhone.Location = new System.Drawing.Point(130, 40);
            this.txtCustomerPhone.MaxLength = 32767;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.PasswordChar = '\0';
            this.txtCustomerPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerPhone.SelectedText = "";
            this.txtCustomerPhone.SelectionLength = 0;
            this.txtCustomerPhone.SelectionStart = 0;
            this.txtCustomerPhone.ShortcutsEnabled = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(371, 30);
            this.txtCustomerPhone.TabIndex = 1;
            this.txtCustomerPhone.UseSelectable = true;
            this.txtCustomerPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel8.Location = new System.Drawing.Point(4, 1);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 35);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Ad Soyad";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel10.Location = new System.Drawing.Point(4, 37);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(119, 36);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Telefon";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(23, 86);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 25);
            this.metroLabel11.TabIndex = 100;
            this.metroLabel11.Text = "Sepet";
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(470, 2);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.DisplayIcon = true;
            this.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBarcode.Icon = global::CashBookApp.WinForm.Properties.Resources.barcode;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(23, 114);
            this.txtBarcode.MaxLength = 64;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PromptText = "BARKOD GİRİN";
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(500, 32);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMark = "BARKOD GİRİN";
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmSalesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tableLayoutPanelPaymentInfo);
            this.Controls.Add(this.tableLayoutPanelCustomerInfo);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dgBasket);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CashBookApp.WinForm.Properties.Settings.Default, "ProgramName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "FrmSalesAdd";
            this.Text = global::CashBookApp.WinForm.Properties.Settings.Default.ProgramName;
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).EndInit();
            this.tableLayoutPanelPaymentInfo.ResumeLayout(false);
            this.tableLayoutPanelPaymentInfo.PerformLayout();
            this.tableLayoutPanelCustomerInfo.ResumeLayout(false);
            this.tableLayoutPanelCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgBasket;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaymentInfo;
        private MetroFramework.Controls.MetroTextBox txtPaymentVal1;
        private MetroFramework.Controls.MetroComboBox cmbPaymentType2;
        private MetroFramework.Controls.MetroComboBox cmbPaymentType1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox chkPartialPayment;
        private MetroFramework.Controls.MetroTextBox txtPaymentVal2;
        private MetroFramework.Controls.MetroTextBox txtDesc1;
        private MetroFramework.Controls.MetroTextBox txtDesc2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomerInfo;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private MetroFramework.Controls.MetroTextBox txtCustomerPhone;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}
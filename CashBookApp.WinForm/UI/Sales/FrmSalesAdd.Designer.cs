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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgBasket = new System.Windows.Forms.DataGridView();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.lblWarning = new MetroFramework.Controls.MetroLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtTransactionTime = new System.Windows.Forms.DateTimePicker();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtTakenAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgPayments = new System.Windows.Forms.DataGridView();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaymentType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnFinish = new MetroFramework.Controls.MetroButton();
            this.btnAddPayment = new MetroFramework.Controls.MetroButton();
            this.btnDelPayment = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).BeginInit();
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
            this.dgBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBasket.EnableHeadersVisualStyles = false;
            this.dgBasket.Location = new System.Drawing.Point(6, 81);
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
            this.dgBasket.Size = new System.Drawing.Size(480, 450);
            this.dgBasket.TabIndex = 2;
            this.dgBasket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBasket_CellClick);
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(450, 2);
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
            this.txtBarcode.Location = new System.Drawing.Point(3, 36);
            this.txtBarcode.MaxLength = 64;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(480, 32);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBarcode_KeyDown);
            // 
            // lblWarning
            // 
            this.lblWarning.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWarning.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarning.Location = new System.Drawing.Point(150, 100);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(362, 33);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarning.UseCustomForeColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.dgBasket);
            this.tabPage2.Controls.Add(this.txtBarcode);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alışveriş Sepeti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Barkod Girin";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(577, 100);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(25, 10);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(500, 576);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroLabel4);
            this.tabPage3.Controls.Add(this.dtTransactionTime);
            this.tabPage3.Controls.Add(this.txtChange);
            this.tabPage3.Controls.Add(this.txtTakenAmount);
            this.tabPage3.Controls.Add(this.txtAmount);
            this.tabPage3.Controls.Add(this.txtCustomerPhone);
            this.tabPage3.Controls.Add(this.cmbCustomerName);
            this.tabPage3.Controls.Add(this.metroPanel1);
            this.tabPage3.Controls.Add(this.metroLabel2);
            this.tabPage3.Controls.Add(this.btnFinish);
            this.tabPage3.Controls.Add(this.btnAddPayment);
            this.tabPage3.Controls.Add(this.btnDelPayment);
            this.tabPage3.Controls.Add(this.metroLabel11);
            this.tabPage3.Controls.Add(this.metroLabel10);
            this.tabPage3.Controls.Add(this.metroLabel9);
            this.tabPage3.Controls.Add(this.metroLabel8);
            this.tabPage3.Controls.Add(this.metroLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(492, 536);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Müşteri && Ödeme Bilgileri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(21, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "İşlem Tarihi";
            // 
            // dtTransactionTime
            // 
            this.dtTransactionTime.Checked = false;
            this.dtTransactionTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtTransactionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTransactionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTransactionTime.Location = new System.Drawing.Point(21, 35);
            this.dtTransactionTime.Name = "dtTransactionTime";
            this.dtTransactionTime.ShowCheckBox = true;
            this.dtTransactionTime.Size = new System.Drawing.Size(450, 32);
            this.dtTransactionTime.TabIndex = 2;
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChange.Location = new System.Drawing.Point(341, 236);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(130, 32);
            this.txtChange.TabIndex = 12;
            this.txtChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressMoney);
            // 
            // txtTakenAmount
            // 
            this.txtTakenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTakenAmount.Location = new System.Drawing.Point(180, 236);
            this.txtTakenAmount.Name = "txtTakenAmount";
            this.txtTakenAmount.Size = new System.Drawing.Size(130, 32);
            this.txtTakenAmount.TabIndex = 10;
            this.txtTakenAmount.TextChanged += new System.EventHandler(this.TxtTakenAmount_TextChanged);
            this.txtTakenAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressMoney);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(21, 236);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(130, 32);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.TextChanged += new System.EventHandler(this.TxtTakenAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressMoney);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(21, 169);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(450, 32);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.BackColor = System.Drawing.Color.White;
            this.cmbCustomerName.DropDownHeight = 200;
            this.cmbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCustomerName.ForeColor = System.Drawing.Color.Black;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.IntegralHeight = false;
            this.cmbCustomerName.ItemHeight = 24;
            this.cmbCustomerName.Location = new System.Drawing.Point(21, 102);
            this.cmbCustomerName.MaxDropDownItems = 10;
            this.cmbCustomerName.MaxLength = 64;
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(450, 32);
            this.cmbCustomerName.TabIndex = 4;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.CmbCustomer_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dgPayments);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(21, 303);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(450, 150);
            this.metroPanel1.TabIndex = 152;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgPayments
            // 
            this.dgPayments.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPayments.ColumnHeadersHeight = 25;
            this.dgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAmount,
            this.ColumnPaymentType,
            this.ColumnDescription});
            this.dgPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPayments.Location = new System.Drawing.Point(0, 0);
            this.dgPayments.MultiSelect = false;
            this.dgPayments.Name = "dgPayments";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPayments.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPayments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPayments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPayments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowTemplate.Height = 32;
            this.dgPayments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPayments.Size = new System.Drawing.Size(448, 148);
            this.dgPayments.TabIndex = 0;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Tutar (₺)";
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnPaymentType
            // 
            this.ColumnPaymentType.HeaderText = "Ödeme Tipi";
            this.ColumnPaymentType.Name = "ColumnPaymentType";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Açıklama";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(21, 281);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Ödeme Bilgileri";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(341, 468);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(130, 42);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "SATIŞI BİTİR";
            this.btnFinish.UseSelectable = true;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(21, 468);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(130, 42);
            this.btnAddPayment.TabIndex = 14;
            this.btnAddPayment.Text = "ÖDEME EKLE";
            this.btnAddPayment.UseSelectable = true;
            this.btnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // btnDelPayment
            // 
            this.btnDelPayment.Location = new System.Drawing.Point(180, 469);
            this.btnDelPayment.Name = "btnDelPayment";
            this.btnDelPayment.Size = new System.Drawing.Size(130, 42);
            this.btnDelPayment.TabIndex = 15;
            this.btnDelPayment.Text = "SEÇİLEN ÖDEMEYİ SİL";
            this.btnDelPayment.UseSelectable = true;
            this.btnDelPayment.Click += new System.EventHandler(this.BtnDelPayment_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(341, 214);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(89, 19);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "Para Üstü (₺)";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(180, 214);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Alınan Ücret (₺)";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(21, 214);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 19);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "İşlem Tutarı (₺)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(21, 147);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Müşteri Telefon";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(21, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Müşteri Ad Soyad";
            // 
            // FrmSalesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CashBookApp.WinForm.Properties.Settings.Default, "ProgramName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "FrmSalesAdd";
            this.Text = global::CashBookApp.WinForm.Properties.Settings.Default.ProgramName;
            this.Load += new System.EventHandler(this.FrmSalesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgBasket;
        private MetroFramework.Controls.MetroLabel lblWarning;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dgPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnFinish;
        private MetroFramework.Controls.MetroButton btnAddPayment;
        private MetroFramework.Controls.MetroButton btnDelPayment;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtTakenAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtTransactionTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
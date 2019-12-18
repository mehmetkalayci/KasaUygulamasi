namespace CashBookApp.WinForm.UI.Sales
{
    partial class FrmSalesReturn
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
            this.dgBasket = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddExpense = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgPayments = new System.Windows.Forms.DataGridView();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).BeginInit();
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
            this.dgBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBasket.EnableHeadersVisualStyles = false;
            this.dgBasket.Location = new System.Drawing.Point(23, 82);
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
            this.dgBasket.Size = new System.Drawing.Size(354, 254);
            this.dgBasket.TabIndex = 1;
            this.dgBasket.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBasket_CellContentDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ürünler";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(566, 342);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(171, 26);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "İade Gideri Ekle";
            this.btnAddExpense.UseSelectable = true;
            this.btnAddExpense.Click += new System.EventHandler(this.BtnAddExpense_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(23, 342);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(354, 88);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "İade İşlemi:\r\n1. İade edilecek ürüne çift tıklayıp, ürünü iade olarak etiketleyin" +
    ".\r\n2. Kasaya Gider Ekle \'ye tıklayıp iade işlemini tamamlayın.";
            this.metroLabel2.WrapToLine = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(383, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "İade Giderleri";
            // 
            // dgPayments
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayments.EnableHeadersVisualStyles = false;
            this.dgPayments.Location = new System.Drawing.Point(383, 82);
            this.dgPayments.MultiSelect = false;
            this.dgPayments.Name = "dgPayments";
            this.dgPayments.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPayments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPayments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPayments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPayments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPayments.Size = new System.Drawing.Size(354, 254);
            this.dgPayments.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(383, 342);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(171, 26);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Seçili Olan Ödemeyi Sil";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // FrmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dgPayments);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgBasket);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalesReturn";
            this.Resizable = false;
            this.Text = "Satış İade İşlemi";
            this.Load += new System.EventHandler(this.FrmSalesReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBasket;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddExpense;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgPayments;
        private MetroFramework.Controls.MetroButton btnDel;
    }
}
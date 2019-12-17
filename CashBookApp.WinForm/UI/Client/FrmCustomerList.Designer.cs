namespace CashBookApp.WinForm.UI.Client
{
    partial class FrmCustomerList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgDataCustomers = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountCustomer = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgDataShoppings = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountShoppings = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataCustomers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataShoppings)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripButtonExcel});
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
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(this.txtFullName);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 620);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(109, 140);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Telefon";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ad Soyad";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(14, 111);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(170, 23);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(14, 63);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(170, 23);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 29);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgDataCustomers);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgDataShoppings);
            this.splitContainer2.Panel2.Controls.Add(this.metroLabel5);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(857, 591);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 4;
            // 
            // dgDataCustomers
            // 
            this.dgDataCustomers.AllowUserToAddRows = false;
            this.dgDataCustomers.AllowUserToDeleteRows = false;
            this.dgDataCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDataCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgDataCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDataCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataCustomers.Location = new System.Drawing.Point(0, 19);
            this.dgDataCustomers.MultiSelect = false;
            this.dgDataCustomers.Name = "dgDataCustomers";
            this.dgDataCustomers.ReadOnly = true;
            this.dgDataCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataCustomers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDataCustomers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDataCustomers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDataCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgDataCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataCustomers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDataCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDataCustomers.Size = new System.Drawing.Size(419, 548);
            this.dgDataCustomers.TabIndex = 7;
            this.dgDataCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDataCustomers_CellContentDoubleClick);
            this.dgDataCustomers.SelectionChanged += new System.EventHandler(this.DgDataCustomers_SelectionChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(419, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Müşteri Listesi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountCustomer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(419, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            // 
            // toolStripStatusLabelCountCustomer
            // 
            this.toolStripStatusLabelCountCustomer.Name = "toolStripStatusLabelCountCustomer";
            this.toolStripStatusLabelCountCustomer.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelCountCustomer.Text = "...";
            // 
            // dgDataShoppings
            // 
            this.dgDataShoppings.AllowUserToAddRows = false;
            this.dgDataShoppings.AllowUserToDeleteRows = false;
            this.dgDataShoppings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDataShoppings.BackgroundColor = System.Drawing.Color.White;
            this.dgDataShoppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDataShoppings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDataShoppings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataShoppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataShoppings.Location = new System.Drawing.Point(0, 19);
            this.dgDataShoppings.MultiSelect = false;
            this.dgDataShoppings.Name = "dgDataShoppings";
            this.dgDataShoppings.ReadOnly = true;
            this.dgDataShoppings.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataShoppings.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDataShoppings.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDataShoppings.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDataShoppings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgDataShoppings.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDataShoppings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDataShoppings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDataShoppings.Size = new System.Drawing.Size(429, 548);
            this.dgDataShoppings.TabIndex = 10;
            this.dgDataShoppings.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDataShoppings_CellContentDoubleClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(429, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Alışveriş Listesi";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountShoppings});
            this.statusStrip2.Location = new System.Drawing.Point(0, 567);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.Size = new System.Drawing.Size(429, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 7;
            // 
            // toolStripStatusLabelCountShoppings
            // 
            this.toolStripStatusLabelCountShoppings.Name = "toolStripStatusLabelCountShoppings";
            this.toolStripStatusLabelCountShoppings.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelCountShoppings.Text = "...";
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCustomerList";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDataCustomers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataShoppings)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgDataCustomers;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountCustomer;
        private System.Windows.Forms.DataGridView dgDataShoppings;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountShoppings;
    }
}
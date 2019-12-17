namespace CashBookApp.WinForm.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlBackupRestore = new MetroFramework.Controls.MetroTile();
            this.tlSalesList = new MetroFramework.Controls.MetroTile();
            this.tlExit = new MetroFramework.Controls.MetroTile();
            this.tlSales = new MetroFramework.Controls.MetroTile();
            this.tlAddExpense = new MetroFramework.Controls.MetroTile();
            this.tlUserSettings = new MetroFramework.Controls.MetroTile();
            this.tlCashBook = new MetroFramework.Controls.MetroTile();
            this.tlStocks = new MetroFramework.Controls.MetroTile();
            this.tlLock = new MetroFramework.Controls.MetroTile();
            this.tlCustomers = new MetroFramework.Controls.MetroTile();
            this.tlAbout = new MetroFramework.Controls.MetroTile();
            this.tlSearchStock = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // tlBackupRestore
            // 
            this.tlBackupRestore.ActiveControl = null;
            this.tlBackupRestore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tlBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlBackupRestore.Location = new System.Drawing.Point(340, 243);
            this.tlBackupRestore.Name = "tlBackupRestore";
            this.tlBackupRestore.Size = new System.Drawing.Size(150, 70);
            this.tlBackupRestore.TabIndex = 2;
            this.tlBackupRestore.Text = "Yedekle && \r\nGeri Yükle";
            this.tlBackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlBackupRestore.TileImage = global::CashBookApp.WinForm.Properties.Resources.servers;
            this.tlBackupRestore.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlBackupRestore.UseCustomBackColor = true;
            this.tlBackupRestore.UseSelectable = true;
            this.tlBackupRestore.UseTileImage = true;
            this.tlBackupRestore.Click += new System.EventHandler(this.TlBackupRestore_Click);
            // 
            // tlSalesList
            // 
            this.tlSalesList.ActiveControl = null;
            this.tlSalesList.BackColor = System.Drawing.Color.Chocolate;
            this.tlSalesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlSalesList.Location = new System.Drawing.Point(28, 243);
            this.tlSalesList.Name = "tlSalesList";
            this.tlSalesList.Size = new System.Drawing.Size(150, 70);
            this.tlSalesList.TabIndex = 1;
            this.tlSalesList.Text = "Satış Listesi";
            this.tlSalesList.TileImage = ((System.Drawing.Image)(resources.GetObject("tlSalesList.TileImage")));
            this.tlSalesList.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlSalesList.UseCustomBackColor = true;
            this.tlSalesList.UseSelectable = true;
            this.tlSalesList.UseTileImage = true;
            this.tlSalesList.Click += new System.EventHandler(this.TlSalesList_Click);
            // 
            // tlExit
            // 
            this.tlExit.ActiveControl = null;
            this.tlExit.BackColor = System.Drawing.Color.Crimson;
            this.tlExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlExit.Location = new System.Drawing.Point(496, 243);
            this.tlExit.Name = "tlExit";
            this.tlExit.Size = new System.Drawing.Size(150, 146);
            this.tlExit.TabIndex = 0;
            this.tlExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlExit.TileImage = global::CashBookApp.WinForm.Properties.Resources.close;
            this.tlExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlExit.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroToolTip1.SetToolTip(this.tlExit, "Programı Kapat");
            this.tlExit.UseCustomBackColor = true;
            this.tlExit.UseSelectable = true;
            this.tlExit.UseTileImage = true;
            this.tlExit.Click += new System.EventHandler(this.TlExit_Click);
            // 
            // tlSales
            // 
            this.tlSales.ActiveControl = null;
            this.tlSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(59)))), ((int)(((byte)(1)))));
            this.tlSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlSales.Location = new System.Drawing.Point(28, 87);
            this.tlSales.Name = "tlSales";
            this.tlSales.Size = new System.Drawing.Size(150, 150);
            this.tlSales.TabIndex = 0;
            this.tlSales.Text = "Satış İşlemleri";
            this.tlSales.TileImage = global::CashBookApp.WinForm.Properties.Resources.shopping_bag;
            this.tlSales.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlSales.UseCustomBackColor = true;
            this.tlSales.UseSelectable = true;
            this.tlSales.UseTileImage = true;
            this.tlSales.Click += new System.EventHandler(this.TlSales_Click);
            // 
            // tlAddExpense
            // 
            this.tlAddExpense.ActiveControl = null;
            this.tlAddExpense.BackColor = System.Drawing.Color.Green;
            this.tlAddExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlAddExpense.Location = new System.Drawing.Point(184, 87);
            this.tlAddExpense.Name = "tlAddExpense";
            this.tlAddExpense.Size = new System.Drawing.Size(150, 150);
            this.tlAddExpense.TabIndex = 0;
            this.tlAddExpense.Text = "Kasa Çıkışları";
            this.tlAddExpense.TileImage = global::CashBookApp.WinForm.Properties.Resources.turkish_lira;
            this.tlAddExpense.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlAddExpense.UseCustomBackColor = true;
            this.tlAddExpense.UseSelectable = true;
            this.tlAddExpense.UseTileImage = true;
            this.tlAddExpense.Click += new System.EventHandler(this.TlAddExpense_Click);
            // 
            // tlUserSettings
            // 
            this.tlUserSettings.ActiveControl = null;
            this.tlUserSettings.BackColor = System.Drawing.Color.Teal;
            this.tlUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlUserSettings.Location = new System.Drawing.Point(184, 319);
            this.tlUserSettings.Name = "tlUserSettings";
            this.tlUserSettings.Size = new System.Drawing.Size(150, 70);
            this.tlUserSettings.TabIndex = 0;
            this.tlUserSettings.Text = "Kullanıcı Ayarları";
            this.tlUserSettings.TileImage = global::CashBookApp.WinForm.Properties.Resources.user_settings;
            this.tlUserSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlUserSettings.UseCustomBackColor = true;
            this.tlUserSettings.UseSelectable = true;
            this.tlUserSettings.UseTileImage = true;
            this.tlUserSettings.Click += new System.EventHandler(this.TlUserSettings_Click);
            // 
            // tlCashBook
            // 
            this.tlCashBook.ActiveControl = null;
            this.tlCashBook.BackColor = System.Drawing.Color.DarkOrchid;
            this.tlCashBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlCashBook.Location = new System.Drawing.Point(340, 87);
            this.tlCashBook.Name = "tlCashBook";
            this.tlCashBook.Size = new System.Drawing.Size(150, 150);
            this.tlCashBook.TabIndex = 0;
            this.tlCashBook.Text = "Gün Sonu";
            this.tlCashBook.TileImage = global::CashBookApp.WinForm.Properties.Resources.approve;
            this.tlCashBook.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlCashBook.UseCustomBackColor = true;
            this.tlCashBook.UseSelectable = true;
            this.tlCashBook.UseTileImage = true;
            this.tlCashBook.Click += new System.EventHandler(this.TlCashBook_Click);
            // 
            // tlStocks
            // 
            this.tlStocks.ActiveControl = null;
            this.tlStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(167)))));
            this.tlStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlStocks.Location = new System.Drawing.Point(496, 87);
            this.tlStocks.Name = "tlStocks";
            this.tlStocks.Size = new System.Drawing.Size(150, 150);
            this.tlStocks.TabIndex = 0;
            this.tlStocks.Text = "Stok İşlemleri";
            this.tlStocks.TileImage = global::CashBookApp.WinForm.Properties.Resources.package_add;
            this.tlStocks.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlStocks.UseCustomBackColor = true;
            this.tlStocks.UseSelectable = true;
            this.tlStocks.UseTileImage = true;
            this.tlStocks.Click += new System.EventHandler(this.TlStocks_Click);
            // 
            // tlLock
            // 
            this.tlLock.ActiveControl = null;
            this.tlLock.BackColor = System.Drawing.Color.DarkOrange;
            this.tlLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlLock.Location = new System.Drawing.Point(418, 319);
            this.tlLock.Name = "tlLock";
            this.tlLock.Size = new System.Drawing.Size(72, 70);
            this.tlLock.TabIndex = 0;
            this.tlLock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlLock.TileImage = global::CashBookApp.WinForm.Properties.Resources.padlock;
            this.tlLock.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlLock.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroToolTip1.SetToolTip(this.tlLock, "Kilitle");
            this.tlLock.UseCustomBackColor = true;
            this.tlLock.UseSelectable = true;
            this.tlLock.UseTileImage = true;
            this.tlLock.Click += new System.EventHandler(this.TlLock_Click);
            // 
            // tlCustomers
            // 
            this.tlCustomers.ActiveControl = null;
            this.tlCustomers.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tlCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlCustomers.Location = new System.Drawing.Point(184, 243);
            this.tlCustomers.Name = "tlCustomers";
            this.tlCustomers.Size = new System.Drawing.Size(150, 70);
            this.tlCustomers.TabIndex = 0;
            this.tlCustomers.Text = "Müşteri Ara";
            this.tlCustomers.TileImage = global::CashBookApp.WinForm.Properties.Resources.search_person;
            this.tlCustomers.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlCustomers.UseCustomBackColor = true;
            this.tlCustomers.UseSelectable = true;
            this.tlCustomers.UseTileImage = true;
            this.tlCustomers.Click += new System.EventHandler(this.TlCustomers_Click);
            // 
            // tlAbout
            // 
            this.tlAbout.ActiveControl = null;
            this.tlAbout.BackColor = System.Drawing.Color.DimGray;
            this.tlAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlAbout.Location = new System.Drawing.Point(340, 319);
            this.tlAbout.Name = "tlAbout";
            this.tlAbout.Size = new System.Drawing.Size(72, 70);
            this.tlAbout.TabIndex = 0;
            this.tlAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlAbout.TileImage = global::CashBookApp.WinForm.Properties.Resources.about;
            this.tlAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroToolTip1.SetToolTip(this.tlAbout, "Program Hakkında");
            this.tlAbout.UseCustomBackColor = true;
            this.tlAbout.UseSelectable = true;
            this.tlAbout.UseTileImage = true;
            this.tlAbout.Click += new System.EventHandler(this.TlAbout_Click);
            // 
            // tlSearchStock
            // 
            this.tlSearchStock.ActiveControl = null;
            this.tlSearchStock.BackColor = System.Drawing.Color.DodgerBlue;
            this.tlSearchStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlSearchStock.Location = new System.Drawing.Point(28, 319);
            this.tlSearchStock.Name = "tlSearchStock";
            this.tlSearchStock.Size = new System.Drawing.Size(150, 70);
            this.tlSearchStock.TabIndex = 0;
            this.tlSearchStock.Text = "Stok Ara";
            this.tlSearchStock.TileImage = global::CashBookApp.WinForm.Properties.Resources.package_search;
            this.tlSearchStock.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlSearchStock.UseCustomBackColor = true;
            this.tlSearchStock.UseSelectable = true;
            this.tlSearchStock.UseTileImage = true;
            this.tlSearchStock.Click += new System.EventHandler(this.TlSearchStock_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.tlBackupRestore);
            this.Controls.Add(this.tlSalesList);
            this.Controls.Add(this.tlExit);
            this.Controls.Add(this.tlSales);
            this.Controls.Add(this.tlAddExpense);
            this.Controls.Add(this.tlUserSettings);
            this.Controls.Add(this.tlCashBook);
            this.Controls.Add(this.tlStocks);
            this.Controls.Add(this.tlLock);
            this.Controls.Add(this.tlCustomers);
            this.Controls.Add(this.tlAbout);
            this.Controls.Add(this.tlSearchStock);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CashBookApp.WinForm.Properties.Settings.Default, "ProgramName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Text = global::CashBookApp.WinForm.Properties.Settings.Default.ProgramName;
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tlSearchStock;
        private MetroFramework.Controls.MetroTile tlCustomers;
        private MetroFramework.Controls.MetroTile tlStocks;
        private MetroFramework.Controls.MetroTile tlAbout;
        private MetroFramework.Controls.MetroTile tlLock;
        private MetroFramework.Controls.MetroTile tlUserSettings;
        private MetroFramework.Controls.MetroTile tlCashBook;
        private MetroFramework.Controls.MetroTile tlAddExpense;
        private MetroFramework.Controls.MetroTile tlSales;
        private MetroFramework.Controls.MetroTile tlExit;
        private MetroFramework.Controls.MetroTile tlSalesList;
        private MetroFramework.Controls.MetroTile tlBackupRestore;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
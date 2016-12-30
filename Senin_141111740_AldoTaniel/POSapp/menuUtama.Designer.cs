namespace LatihanPos
{
    partial class menuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuUtama));
            this.customer = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.master = new MetroFramework.Controls.MetroTile();
            this.supplier = new MetroFramework.Controls.MetroTile();
            this.barang = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.ActiveControl = null;
            this.customer.Location = new System.Drawing.Point(23, 159);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(194, 94);
            this.customer.TabIndex = 0;
            this.customer.Text = "Customer";
            this.customer.TileImage = global::LatihanPos.Properties.Resources.Users_icon;
            this.customer.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer.UseSelectable = true;
            this.customer.UseTileImage = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(223, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(193, 90);
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "Beli";
            this.metroTile2.TileImage = global::LatihanPos.Properties.Resources.Shopping_basket_add_icon;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.UseMnemonic = false;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(223, 159);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(95, 94);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Jual";
            this.metroTile1.TileImage = global::LatihanPos.Properties.Resources.Shop_icon;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseMnemonic = false;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // master
            // 
            this.master.ActiveControl = null;
            this.master.Location = new System.Drawing.Point(324, 159);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(95, 94);
            this.master.TabIndex = 0;
            this.master.Text = "Master";
            this.master.TileImage = global::LatihanPos.Properties.Resources.Manager_Suit_Red_Tie_icon;
            this.master.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.master.UseMnemonic = false;
            this.master.UseSelectable = true;
            this.master.UseTileImage = true;
            // 
            // supplier
            // 
            this.supplier.ActiveControl = null;
            this.supplier.Location = new System.Drawing.Point(123, 63);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(94, 90);
            this.supplier.TabIndex = 0;
            this.supplier.Text = "Supplier";
            this.supplier.TileImage = global::LatihanPos.Properties.Resources.Male_user_add_icon;
            this.supplier.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.supplier.UseSelectable = true;
            this.supplier.UseTileImage = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // barang
            // 
            this.barang.ActiveControl = null;
            this.barang.Location = new System.Drawing.Point(23, 63);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(94, 90);
            this.barang.TabIndex = 0;
            this.barang.Text = "Barang";
            this.barang.TileImage = global::LatihanPos.Properties.Resources.box_download_icon;
            this.barang.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.barang.UseSelectable = true;
            this.barang.UseTileImage = true;
            this.barang.Click += new System.EventHandler(this.barang_Click);
            // 
            // menuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 274);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.master);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.barang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuUtama";
            this.Text = "Menu Utama";
            this.Load += new System.EventHandler(this.menuUtama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile barang;
        private MetroFramework.Controls.MetroTile supplier;
        private MetroFramework.Controls.MetroTile customer;
        private MetroFramework.Controls.MetroTile master;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}
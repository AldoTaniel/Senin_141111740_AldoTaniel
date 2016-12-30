namespace LatihanPos
{
    partial class pembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pembelian));
            this.save = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblsubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tblBarang = new MetroFramework.Controls.MetroTile();
            this.cancel = new MetroFramework.Controls.MetroTile();
            this.beli = new MetroFramework.Controls.MetroTile();
            this.fakturpembelian = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btncekBarang = new MetroFramework.Controls.MetroButton();
            this.jumlah = new MetroFramework.Controls.MetroTextBox();
            this.stock = new MetroFramework.Controls.MetroTextBox();
            this.hrgBarang = new MetroFramework.Controls.MetroTextBox();
            this.nmBarang = new MetroFramework.Controls.MetroTextBox();
            this.kodeBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nm_perusahaan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.kodesupplier = new MetroFramework.Controls.MetroTextBox();
            this.lbltotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.cari = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(11, 209);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(541, 24);
            this.save.TabIndex = 80;
            this.save.Text = "Tambah Ke List";
            this.save.UseCustomBackColor = true;
            this.save.UseCustomForeColor = true;
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(377, 449);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 79;
            this.metroLabel7.Text = "Sub Total";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsubtotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblsubtotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblsubtotal.Location = new System.Drawing.Point(380, 475);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(172, 24);
            this.lblsubtotal.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblsubtotal.TabIndex = 78;
            this.lblsubtotal.Text = "Rp.";
            this.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(278, 449);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(83, 72);
            this.metroTile1.TabIndex = 77;
            this.metroTile1.Text = "Cancel";
            this.metroTile1.TileImage = global::LatihanPos.Properties.Resources.Misc_Delete_Database_icon;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tblBarang
            // 
            this.tblBarang.ActiveControl = null;
            this.tblBarang.Location = new System.Drawing.Point(189, 449);
            this.tblBarang.Name = "tblBarang";
            this.tblBarang.Size = new System.Drawing.Size(83, 72);
            this.tblBarang.TabIndex = 76;
            this.tblBarang.Text = "Barang";
            this.tblBarang.TileImage = global::LatihanPos.Properties.Resources.box_download_icon_;
            this.tblBarang.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tblBarang.UseSelectable = true;
            this.tblBarang.UseTileImage = true;
            this.tblBarang.Click += new System.EventHandler(this.tblBarang_Click);
            // 
            // cancel
            // 
            this.cancel.ActiveControl = null;
            this.cancel.Location = new System.Drawing.Point(100, 449);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(83, 72);
            this.cancel.TabIndex = 75;
            this.cancel.Text = "Hapus";
            this.cancel.TileImage = global::LatihanPos.Properties.Resources.Delete_icon;
            this.cancel.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel.UseSelectable = true;
            this.cancel.UseTileImage = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // beli
            // 
            this.beli.ActiveControl = null;
            this.beli.Location = new System.Drawing.Point(11, 449);
            this.beli.Name = "beli";
            this.beli.Size = new System.Drawing.Size(83, 72);
            this.beli.TabIndex = 74;
            this.beli.Text = "Beli";
            this.beli.TileImage = global::LatihanPos.Properties.Resources.Cash_icon;
            this.beli.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.beli.UseSelectable = true;
            this.beli.UseTileImage = true;
            this.beli.Click += new System.EventHandler(this.beli_Click);
            // 
            // fakturpembelian
            // 
            this.fakturpembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.fakturpembelian.CustomButton.Image = null;
            this.fakturpembelian.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.fakturpembelian.CustomButton.Name = "";
            this.fakturpembelian.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fakturpembelian.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fakturpembelian.CustomButton.TabIndex = 1;
            this.fakturpembelian.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fakturpembelian.CustomButton.UseSelectable = true;
            this.fakturpembelian.CustomButton.Visible = false;
            this.fakturpembelian.Lines = new string[0];
            this.fakturpembelian.Location = new System.Drawing.Point(455, 120);
            this.fakturpembelian.MaxLength = 32767;
            this.fakturpembelian.Name = "fakturpembelian";
            this.fakturpembelian.PasswordChar = '\0';
            this.fakturpembelian.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fakturpembelian.SelectedText = "";
            this.fakturpembelian.SelectionLength = 0;
            this.fakturpembelian.SelectionStart = 0;
            this.fakturpembelian.ShortcutsEnabled = true;
            this.fakturpembelian.Size = new System.Drawing.Size(98, 23);
            this.fakturpembelian.TabIndex = 73;
            this.fakturpembelian.UseCustomBackColor = true;
            this.fakturpembelian.UseSelectable = true;
            this.fakturpembelian.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fakturpembelian.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(334, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 19);
            this.metroLabel5.TabIndex = 72;
            this.metroLabel5.Text = "Faktur Pembelian";
            // 
            // btncekBarang
            // 
            this.btncekBarang.Location = new System.Drawing.Point(224, 180);
            this.btncekBarang.Name = "btncekBarang";
            this.btncekBarang.Size = new System.Drawing.Size(27, 23);
            this.btncekBarang.TabIndex = 71;
            this.btncekBarang.Text = "+";
            this.btncekBarang.UseSelectable = true;
            this.btncekBarang.Click += new System.EventHandler(this.btncekBarang_Click);
            // 
            // jumlah
            // 
            // 
            // 
            // 
            this.jumlah.CustomButton.Image = null;
            this.jumlah.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.jumlah.CustomButton.Name = "";
            this.jumlah.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlah.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlah.CustomButton.TabIndex = 1;
            this.jumlah.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlah.CustomButton.UseSelectable = true;
            this.jumlah.CustomButton.Visible = false;
            this.jumlah.Lines = new string[0];
            this.jumlah.Location = new System.Drawing.Point(502, 180);
            this.jumlah.MaxLength = 32767;
            this.jumlah.Name = "jumlah";
            this.jumlah.PasswordChar = '\0';
            this.jumlah.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlah.SelectedText = "";
            this.jumlah.SelectionLength = 0;
            this.jumlah.SelectionStart = 0;
            this.jumlah.ShortcutsEnabled = true;
            this.jumlah.Size = new System.Drawing.Size(50, 23);
            this.jumlah.TabIndex = 70;
            this.jumlah.UseSelectable = true;
            this.jumlah.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlah.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.stock.CustomButton.Image = null;
            this.stock.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.stock.CustomButton.Name = "";
            this.stock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.stock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stock.CustomButton.TabIndex = 1;
            this.stock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stock.CustomButton.UseSelectable = true;
            this.stock.CustomButton.Visible = false;
            this.stock.Lines = new string[0];
            this.stock.Location = new System.Drawing.Point(457, 180);
            this.stock.MaxLength = 32767;
            this.stock.Name = "stock";
            this.stock.PasswordChar = '\0';
            this.stock.ReadOnly = true;
            this.stock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stock.SelectedText = "";
            this.stock.SelectionLength = 0;
            this.stock.SelectionStart = 0;
            this.stock.ShortcutsEnabled = true;
            this.stock.Size = new System.Drawing.Size(39, 23);
            this.stock.TabIndex = 69;
            this.stock.UseCustomBackColor = true;
            this.stock.UseSelectable = true;
            this.stock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // hrgBarang
            // 
            this.hrgBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.hrgBarang.CustomButton.Image = null;
            this.hrgBarang.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.hrgBarang.CustomButton.Name = "";
            this.hrgBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hrgBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hrgBarang.CustomButton.TabIndex = 1;
            this.hrgBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hrgBarang.CustomButton.UseSelectable = true;
            this.hrgBarang.CustomButton.Visible = false;
            this.hrgBarang.Lines = new string[0];
            this.hrgBarang.Location = new System.Drawing.Point(377, 180);
            this.hrgBarang.MaxLength = 32767;
            this.hrgBarang.Name = "hrgBarang";
            this.hrgBarang.PasswordChar = '\0';
            this.hrgBarang.ReadOnly = true;
            this.hrgBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hrgBarang.SelectedText = "";
            this.hrgBarang.SelectionLength = 0;
            this.hrgBarang.SelectionStart = 0;
            this.hrgBarang.ShortcutsEnabled = true;
            this.hrgBarang.Size = new System.Drawing.Size(74, 23);
            this.hrgBarang.TabIndex = 68;
            this.hrgBarang.UseCustomBackColor = true;
            this.hrgBarang.UseSelectable = true;
            this.hrgBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hrgBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nmBarang
            // 
            this.nmBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.nmBarang.CustomButton.Image = null;
            this.nmBarang.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.nmBarang.CustomButton.Name = "";
            this.nmBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nmBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nmBarang.CustomButton.TabIndex = 1;
            this.nmBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nmBarang.CustomButton.UseSelectable = true;
            this.nmBarang.CustomButton.Visible = false;
            this.nmBarang.Lines = new string[0];
            this.nmBarang.Location = new System.Drawing.Point(257, 180);
            this.nmBarang.MaxLength = 32767;
            this.nmBarang.Name = "nmBarang";
            this.nmBarang.PasswordChar = '\0';
            this.nmBarang.ReadOnly = true;
            this.nmBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nmBarang.SelectedText = "";
            this.nmBarang.SelectionLength = 0;
            this.nmBarang.SelectionStart = 0;
            this.nmBarang.ShortcutsEnabled = true;
            this.nmBarang.Size = new System.Drawing.Size(114, 23);
            this.nmBarang.TabIndex = 67;
            this.nmBarang.UseCustomBackColor = true;
            this.nmBarang.UseSelectable = true;
            this.nmBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nmBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kodeBarang
            // 
            this.kodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.kodeBarang.CustomButton.Image = null;
            this.kodeBarang.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.kodeBarang.CustomButton.Name = "";
            this.kodeBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodeBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodeBarang.CustomButton.TabIndex = 1;
            this.kodeBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodeBarang.CustomButton.UseSelectable = true;
            this.kodeBarang.CustomButton.Visible = false;
            this.kodeBarang.Lines = new string[0];
            this.kodeBarang.Location = new System.Drawing.Point(132, 180);
            this.kodeBarang.MaxLength = 32767;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.PasswordChar = '\0';
            this.kodeBarang.ReadOnly = true;
            this.kodeBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodeBarang.SelectedText = "";
            this.kodeBarang.SelectionLength = 0;
            this.kodeBarang.SelectionStart = 0;
            this.kodeBarang.ShortcutsEnabled = true;
            this.kodeBarang.Size = new System.Drawing.Size(86, 23);
            this.kodeBarang.TabIndex = 66;
            this.kodeBarang.UseCustomBackColor = true;
            this.kodeBarang.UseSelectable = true;
            this.kodeBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodeBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "Kode Barang";
            // 
            // nm_perusahaan
            // 
            // 
            // 
            // 
            this.nm_perusahaan.CustomButton.Image = null;
            this.nm_perusahaan.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.nm_perusahaan.CustomButton.Name = "";
            this.nm_perusahaan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nm_perusahaan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nm_perusahaan.CustomButton.TabIndex = 1;
            this.nm_perusahaan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nm_perusahaan.CustomButton.UseSelectable = true;
            this.nm_perusahaan.CustomButton.Visible = false;
            this.nm_perusahaan.Lines = new string[0];
            this.nm_perusahaan.Location = new System.Drawing.Point(132, 149);
            this.nm_perusahaan.MaxLength = 32767;
            this.nm_perusahaan.Name = "nm_perusahaan";
            this.nm_perusahaan.PasswordChar = '\0';
            this.nm_perusahaan.ReadOnly = true;
            this.nm_perusahaan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nm_perusahaan.SelectedText = "";
            this.nm_perusahaan.SelectionLength = 0;
            this.nm_perusahaan.SelectionStart = 0;
            this.nm_perusahaan.ShortcutsEnabled = true;
            this.nm_perusahaan.Size = new System.Drawing.Size(127, 23);
            this.nm_perusahaan.TabIndex = 64;
            this.nm_perusahaan.UseSelectable = true;
            this.nm_perusahaan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nm_perusahaan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "Nama Perusahaan";
            // 
            // kodesupplier
            // 
            // 
            // 
            // 
            this.kodesupplier.CustomButton.Image = null;
            this.kodesupplier.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.kodesupplier.CustomButton.Name = "";
            this.kodesupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodesupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodesupplier.CustomButton.TabIndex = 1;
            this.kodesupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodesupplier.CustomButton.UseSelectable = true;
            this.kodesupplier.CustomButton.Visible = false;
            this.kodesupplier.Lines = new string[0];
            this.kodesupplier.Location = new System.Drawing.Point(132, 120);
            this.kodesupplier.MaxLength = 32767;
            this.kodesupplier.Name = "kodesupplier";
            this.kodesupplier.PasswordChar = '\0';
            this.kodesupplier.ReadOnly = true;
            this.kodesupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodesupplier.SelectedText = "";
            this.kodesupplier.SelectionLength = 0;
            this.kodesupplier.SelectionStart = 0;
            this.kodesupplier.ShortcutsEnabled = true;
            this.kodesupplier.Size = new System.Drawing.Size(86, 23);
            this.kodesupplier.TabIndex = 62;
            this.kodesupplier.UseSelectable = true;
            this.kodesupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodesupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.kodesupplier.TextChanged += new System.EventHandler(this.kodesupplier_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbltotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltotal.Location = new System.Drawing.Point(4, 56);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(548, 55);
            this.lbltotal.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbltotal.TabIndex = 61;
            this.lbltotal.Text = "Rp.";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Kode Suplier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 202);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.metroLink2);
            this.metroPanel1.Controls.Add(this.cari);
            this.metroPanel1.Controls.Add(this.dataGridView2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 120);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(548, 293);
            this.metroPanel1.TabIndex = 81;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLink2
            // 
            this.metroLink2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink2.Image = global::LatihanPos.Properties.Resources._1482448658_circle_edit_search_thin;
            this.metroLink2.ImageSize = 64;
            this.metroLink2.Location = new System.Drawing.Point(303, 16);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(64, 23);
            this.metroLink2.TabIndex = 10;
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // cari
            // 
            // 
            // 
            // 
            this.cari.CustomButton.Image = null;
            this.cari.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.cari.CustomButton.Name = "";
            this.cari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cari.CustomButton.TabIndex = 1;
            this.cari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cari.CustomButton.UseSelectable = true;
            this.cari.CustomButton.Visible = false;
            this.cari.Lines = new string[0];
            this.cari.Location = new System.Drawing.Point(364, 16);
            this.cari.MaxLength = 32767;
            this.cari.Name = "cari";
            this.cari.PasswordChar = '\0';
            this.cari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cari.SelectedText = "";
            this.cari.SelectionLength = 0;
            this.cari.SelectionStart = 0;
            this.cari.ShortcutsEnabled = true;
            this.cari.Size = new System.Drawing.Size(162, 23);
            this.cari.TabIndex = 9;
            this.cari.UseSelectable = true;
            this.cari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(525, 241);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 533);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tblBarang);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.beli);
            this.Controls.Add(this.fakturpembelian);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btncekBarang);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.hrgBarang);
            this.Controls.Add(this.nmBarang);
            this.Controls.Add(this.kodeBarang);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nm_perusahaan);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.kodesupplier);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblsubtotal;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile tblBarang;
        private MetroFramework.Controls.MetroTile cancel;
        private MetroFramework.Controls.MetroTile beli;
        private MetroFramework.Controls.MetroTextBox fakturpembelian;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btncekBarang;
        private MetroFramework.Controls.MetroTextBox jumlah;
        private MetroFramework.Controls.MetroTextBox stock;
        private MetroFramework.Controls.MetroTextBox hrgBarang;
        private MetroFramework.Controls.MetroTextBox nmBarang;
        private MetroFramework.Controls.MetroTextBox kodeBarang;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox nm_perusahaan;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox kodesupplier;
        private MetroFramework.Controls.MetroLabel lbltotal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTextBox cari;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
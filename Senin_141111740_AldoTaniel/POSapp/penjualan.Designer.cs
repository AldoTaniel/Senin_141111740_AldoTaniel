namespace LatihanPos
{
    partial class penjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penjualan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbltotal = new MetroFramework.Controls.MetroLabel();
            this.kodecust = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nm_cust = new MetroFramework.Controls.MetroTextBox();
            this.kodeBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nmBarang = new MetroFramework.Controls.MetroTextBox();
            this.hrgBarang = new MetroFramework.Controls.MetroTextBox();
            this.stock = new MetroFramework.Controls.MetroTextBox();
            this.jumlah = new MetroFramework.Controls.MetroTextBox();
            this.btncekBarang = new MetroFramework.Controls.MetroButton();
            this.fakturpenjualan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblsubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.save = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.cari = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.byrBayar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.byrCancel = new MetroFramework.Controls.MetroButton();
            this.byrBtnBayar = new MetroFramework.Controls.MetroButton();
            this.byrKembali = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.byrSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tblBarang = new MetroFramework.Controls.MetroTile();
            this.cancel = new MetroFramework.Controls.MetroTile();
            this.bayar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kode Customer";
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbltotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltotal.Location = new System.Drawing.Point(5, 60);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(548, 55);
            this.lbltotal.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "Rp.";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // kodecust
            // 
            // 
            // 
            // 
            this.kodecust.CustomButton.Image = null;
            this.kodecust.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.kodecust.CustomButton.Name = "";
            this.kodecust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodecust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodecust.CustomButton.TabIndex = 1;
            this.kodecust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodecust.CustomButton.UseSelectable = true;
            this.kodecust.CustomButton.Visible = false;
            this.kodecust.Lines = new string[0];
            this.kodecust.Location = new System.Drawing.Point(133, 124);
            this.kodecust.MaxLength = 32767;
            this.kodecust.Name = "kodecust";
            this.kodecust.PasswordChar = '\0';
            this.kodecust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodecust.SelectedText = "";
            this.kodecust.SelectionLength = 0;
            this.kodecust.SelectionStart = 0;
            this.kodecust.ShortcutsEnabled = true;
            this.kodecust.Size = new System.Drawing.Size(86, 23);
            this.kodecust.TabIndex = 3;
            this.kodecust.UseSelectable = true;
            this.kodecust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodecust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.kodecust.TextChanged += new System.EventHandler(this.kodecust_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Nama Customer";
            // 
            // nm_cust
            // 
            // 
            // 
            // 
            this.nm_cust.CustomButton.Image = null;
            this.nm_cust.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.nm_cust.CustomButton.Name = "";
            this.nm_cust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nm_cust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nm_cust.CustomButton.TabIndex = 1;
            this.nm_cust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nm_cust.CustomButton.UseSelectable = true;
            this.nm_cust.CustomButton.Visible = false;
            this.nm_cust.Lines = new string[0];
            this.nm_cust.Location = new System.Drawing.Point(133, 153);
            this.nm_cust.MaxLength = 32767;
            this.nm_cust.Name = "nm_cust";
            this.nm_cust.PasswordChar = '\0';
            this.nm_cust.ReadOnly = true;
            this.nm_cust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nm_cust.SelectedText = "";
            this.nm_cust.SelectionLength = 0;
            this.nm_cust.SelectionStart = 0;
            this.nm_cust.ShortcutsEnabled = true;
            this.nm_cust.Size = new System.Drawing.Size(86, 23);
            this.nm_cust.TabIndex = 5;
            this.nm_cust.UseSelectable = true;
            this.nm_cust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nm_cust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.kodeBarang.Location = new System.Drawing.Point(133, 184);
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
            this.kodeBarang.TabIndex = 7;
            this.kodeBarang.UseCustomBackColor = true;
            this.kodeBarang.UseSelectable = true;
            this.kodeBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodeBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Kode Barang";
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
            this.nmBarang.Location = new System.Drawing.Point(258, 184);
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
            this.nmBarang.TabIndex = 8;
            this.nmBarang.UseCustomBackColor = true;
            this.nmBarang.UseSelectable = true;
            this.nmBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nmBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.hrgBarang.Location = new System.Drawing.Point(378, 184);
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
            this.hrgBarang.TabIndex = 9;
            this.hrgBarang.UseCustomBackColor = true;
            this.hrgBarang.UseSelectable = true;
            this.hrgBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hrgBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.stock.Location = new System.Drawing.Point(458, 184);
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
            this.stock.TabIndex = 10;
            this.stock.UseCustomBackColor = true;
            this.stock.UseSelectable = true;
            this.stock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.jumlah.Location = new System.Drawing.Point(503, 184);
            this.jumlah.MaxLength = 32767;
            this.jumlah.Name = "jumlah";
            this.jumlah.PasswordChar = '\0';
            this.jumlah.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlah.SelectedText = "";
            this.jumlah.SelectionLength = 0;
            this.jumlah.SelectionStart = 0;
            this.jumlah.ShortcutsEnabled = true;
            this.jumlah.Size = new System.Drawing.Size(50, 23);
            this.jumlah.TabIndex = 11;
            this.jumlah.UseSelectable = true;
            this.jumlah.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlah.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btncekBarang
            // 
            this.btncekBarang.Location = new System.Drawing.Point(225, 184);
            this.btncekBarang.Name = "btncekBarang";
            this.btncekBarang.Size = new System.Drawing.Size(27, 23);
            this.btncekBarang.TabIndex = 12;
            this.btncekBarang.Text = "+";
            this.btncekBarang.UseSelectable = true;
            this.btncekBarang.Click += new System.EventHandler(this.btncekBarang_Click);
            // 
            // fakturpenjualan
            // 
            this.fakturpenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.fakturpenjualan.CustomButton.Image = null;
            this.fakturpenjualan.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.fakturpenjualan.CustomButton.Name = "";
            this.fakturpenjualan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fakturpenjualan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fakturpenjualan.CustomButton.TabIndex = 1;
            this.fakturpenjualan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fakturpenjualan.CustomButton.UseSelectable = true;
            this.fakturpenjualan.CustomButton.Visible = false;
            this.fakturpenjualan.Lines = new string[0];
            this.fakturpenjualan.Location = new System.Drawing.Point(456, 124);
            this.fakturpenjualan.MaxLength = 32767;
            this.fakturpenjualan.Name = "fakturpenjualan";
            this.fakturpenjualan.PasswordChar = '\0';
            this.fakturpenjualan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fakturpenjualan.SelectedText = "";
            this.fakturpenjualan.SelectionLength = 0;
            this.fakturpenjualan.SelectionStart = 0;
            this.fakturpenjualan.ShortcutsEnabled = true;
            this.fakturpenjualan.Size = new System.Drawing.Size(98, 23);
            this.fakturpenjualan.TabIndex = 14;
            this.fakturpenjualan.UseCustomBackColor = true;
            this.fakturpenjualan.UseSelectable = true;
            this.fakturpenjualan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fakturpenjualan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(335, 124);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Faktur Penjualan";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsubtotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblsubtotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblsubtotal.Location = new System.Drawing.Point(381, 479);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(172, 24);
            this.lblsubtotal.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblsubtotal.TabIndex = 16;
            this.lblsubtotal.Text = "Rp.";
            this.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(378, 453);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Sub Total";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(12, 213);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(541, 24);
            this.save.TabIndex = 58;
            this.save.Text = "Tambah Ke List";
            this.save.UseCustomBackColor = true;
            this.save.UseCustomForeColor = true;
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.metroPanel1.Location = new System.Drawing.Point(15, 243);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(542, 293);
            this.metroPanel1.TabIndex = 59;
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.byrBayar);
            this.metroPanel2.Controls.Add(this.metroLabel15);
            this.metroPanel2.Controls.Add(this.byrCancel);
            this.metroPanel2.Controls.Add(this.byrBtnBayar);
            this.metroPanel2.Controls.Add(this.byrKembali);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.Controls.Add(this.byrSubtotal);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(144, 26);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(305, 211);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // byrBayar
            // 
            // 
            // 
            // 
            this.byrBayar.CustomButton.Image = null;
            this.byrBayar.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.byrBayar.CustomButton.Name = "";
            this.byrBayar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.byrBayar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.byrBayar.CustomButton.TabIndex = 1;
            this.byrBayar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.byrBayar.CustomButton.UseSelectable = true;
            this.byrBayar.CustomButton.Visible = false;
            this.byrBayar.Lines = new string[0];
            this.byrBayar.Location = new System.Drawing.Point(116, 101);
            this.byrBayar.MaxLength = 32767;
            this.byrBayar.Name = "byrBayar";
            this.byrBayar.PasswordChar = '\0';
            this.byrBayar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.byrBayar.SelectedText = "";
            this.byrBayar.SelectionLength = 0;
            this.byrBayar.SelectionStart = 0;
            this.byrBayar.ShortcutsEnabled = true;
            this.byrBayar.Size = new System.Drawing.Size(172, 23);
            this.byrBayar.TabIndex = 75;
            this.byrBayar.UseSelectable = true;
            this.byrBayar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.byrBayar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.byrBayar.TextChanged += new System.EventHandler(this.byrBayar_TextChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(38, 101);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(42, 19);
            this.metroLabel15.TabIndex = 74;
            this.metroLabel15.Text = "Bayar";
            // 
            // byrCancel
            // 
            this.byrCancel.BackColor = System.Drawing.Color.Crimson;
            this.byrCancel.ForeColor = System.Drawing.Color.White;
            this.byrCancel.Location = new System.Drawing.Point(196, 160);
            this.byrCancel.Name = "byrCancel";
            this.byrCancel.Size = new System.Drawing.Size(74, 29);
            this.byrCancel.TabIndex = 73;
            this.byrCancel.Text = "Cancel";
            this.byrCancel.UseCustomBackColor = true;
            this.byrCancel.UseCustomForeColor = true;
            this.byrCancel.UseSelectable = true;
            this.byrCancel.Click += new System.EventHandler(this.byrCancel_Click);
            // 
            // byrBtnBayar
            // 
            this.byrBtnBayar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.byrBtnBayar.ForeColor = System.Drawing.Color.White;
            this.byrBtnBayar.Location = new System.Drawing.Point(116, 160);
            this.byrBtnBayar.Name = "byrBtnBayar";
            this.byrBtnBayar.Size = new System.Drawing.Size(74, 29);
            this.byrBtnBayar.TabIndex = 72;
            this.byrBtnBayar.Text = "Bayar";
            this.byrBtnBayar.UseCustomBackColor = true;
            this.byrBtnBayar.UseCustomForeColor = true;
            this.byrBtnBayar.UseSelectable = true;
            this.byrBtnBayar.Click += new System.EventHandler(this.byrBtnBayar_Click);
            // 
            // byrKembali
            // 
            // 
            // 
            // 
            this.byrKembali.CustomButton.Image = null;
            this.byrKembali.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.byrKembali.CustomButton.Name = "";
            this.byrKembali.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.byrKembali.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.byrKembali.CustomButton.TabIndex = 1;
            this.byrKembali.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.byrKembali.CustomButton.UseSelectable = true;
            this.byrKembali.CustomButton.Visible = false;
            this.byrKembali.Lines = new string[0];
            this.byrKembali.Location = new System.Drawing.Point(116, 130);
            this.byrKembali.MaxLength = 32767;
            this.byrKembali.Name = "byrKembali";
            this.byrKembali.PasswordChar = '\0';
            this.byrKembali.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.byrKembali.SelectedText = "";
            this.byrKembali.SelectionLength = 0;
            this.byrKembali.SelectionStart = 0;
            this.byrKembali.ShortcutsEnabled = true;
            this.byrKembali.Size = new System.Drawing.Size(172, 23);
            this.byrKembali.TabIndex = 71;
            this.byrKembali.UseSelectable = true;
            this.byrKembali.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.byrKembali.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(38, 130);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(56, 19);
            this.metroLabel14.TabIndex = 70;
            this.metroLabel14.Text = "Kembali";
            // 
            // byrSubtotal
            // 
            // 
            // 
            // 
            this.byrSubtotal.CustomButton.Image = null;
            this.byrSubtotal.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.byrSubtotal.CustomButton.Name = "";
            this.byrSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.byrSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.byrSubtotal.CustomButton.TabIndex = 1;
            this.byrSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.byrSubtotal.CustomButton.UseSelectable = true;
            this.byrSubtotal.CustomButton.Visible = false;
            this.byrSubtotal.Lines = new string[0];
            this.byrSubtotal.Location = new System.Drawing.Point(116, 42);
            this.byrSubtotal.MaxLength = 32767;
            this.byrSubtotal.Name = "byrSubtotal";
            this.byrSubtotal.PasswordChar = '\0';
            this.byrSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.byrSubtotal.SelectedText = "";
            this.byrSubtotal.SelectionLength = 0;
            this.byrSubtotal.SelectionStart = 0;
            this.byrSubtotal.ShortcutsEnabled = true;
            this.byrSubtotal.Size = new System.Drawing.Size(172, 23);
            this.byrSubtotal.TabIndex = 65;
            this.byrSubtotal.UseSelectable = true;
            this.byrSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.byrSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 42);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Subtotal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(20, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Bayar";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(259, 162);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 19);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "Nama Barang";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(378, 162);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 61;
            this.metroLabel9.Text = "Harga";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(458, 162);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(40, 19);
            this.metroLabel10.TabIndex = 62;
            this.metroLabel10.Text = "Stock";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(500, 162);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 19);
            this.metroLabel11.TabIndex = 63;
            this.metroLabel11.Text = "Jumlah";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(279, 453);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(83, 72);
            this.metroTile1.TabIndex = 15;
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
            this.tblBarang.Location = new System.Drawing.Point(190, 453);
            this.tblBarang.Name = "tblBarang";
            this.tblBarang.Size = new System.Drawing.Size(83, 72);
            this.tblBarang.TabIndex = 15;
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
            this.cancel.Location = new System.Drawing.Point(101, 453);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(83, 72);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Hapus";
            this.cancel.TileImage = global::LatihanPos.Properties.Resources.Delete_icon;
            this.cancel.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel.UseSelectable = true;
            this.cancel.UseTileImage = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // bayar
            // 
            this.bayar.ActiveControl = null;
            this.bayar.Location = new System.Drawing.Point(12, 453);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(83, 72);
            this.bayar.TabIndex = 15;
            this.bayar.Text = "Bayar";
            this.bayar.TileImage = global::LatihanPos.Properties.Resources.Cash_icon;
            this.bayar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bayar.UseSelectable = true;
            this.bayar.UseTileImage = true;
            this.bayar.Click += new System.EventHandler(this.bayar_Click);
            // 
            // penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 550);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tblBarang);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.fakturpenjualan);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btncekBarang);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.hrgBarang);
            this.Controls.Add(this.nmBarang);
            this.Controls.Add(this.kodeBarang);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nm_cust);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.kodecust);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "penjualan";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbltotal;
        private MetroFramework.Controls.MetroTextBox kodecust;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox nm_cust;
        private MetroFramework.Controls.MetroTextBox kodeBarang;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox nmBarang;
        private MetroFramework.Controls.MetroTextBox hrgBarang;
        private MetroFramework.Controls.MetroTextBox stock;
        private MetroFramework.Controls.MetroTextBox jumlah;
        private MetroFramework.Controls.MetroButton btncekBarang;
        private MetroFramework.Controls.MetroTextBox fakturpenjualan;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile bayar;
        private MetroFramework.Controls.MetroTile cancel;
        private MetroFramework.Controls.MetroTile tblBarang;
        private MetroFramework.Controls.MetroLabel lblsubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTextBox cari;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox byrKembali;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox byrSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton byrCancel;
        private MetroFramework.Controls.MetroButton byrBtnBayar;
        private MetroFramework.Controls.MetroTextBox byrBayar;
        private MetroFramework.Controls.MetroLabel metroLabel15;
    }
}
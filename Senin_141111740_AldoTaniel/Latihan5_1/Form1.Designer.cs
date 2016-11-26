namespace Latihan_5_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSize = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripBold = new System.Windows.Forms.ToolStripButton();
            this.ToolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.ToolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFont = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripColor = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripBackgrounColor = new System.Windows.Forms.ToolStripComboBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svDialog = new System.Windows.Forms.SaveFileDialog();
            this.opDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSize,
            this.ToolStripBold,
            this.ToolStripItalic,
            this.ToolStripUnderline,
            this.ToolStripFont,
            this.ToolStripColor,
            this.ToolStripBackgrounColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripSize
            // 
            this.ToolStripSize.Name = "ToolStripSize";
            this.ToolStripSize.Size = new System.Drawing.Size(121, 25);
            this.ToolStripSize.SelectedIndexChanged += new System.EventHandler(this.tsSize_SelectedIndexChanged);
            // 
            // ToolStripBold
            // 
            this.ToolStripBold.CheckOnClick = true;
            this.ToolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBold.Image")));
            this.ToolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBold.Name = "ToolStripBold";
            this.ToolStripBold.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBold.Text = "Bold";
            this.ToolStripBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // ToolStripItalic
            // 
            this.ToolStripItalic.CheckOnClick = true;
            this.ToolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripItalic.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripItalic.Image")));
            this.ToolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItalic.Name = "ToolStripItalic";
            this.ToolStripItalic.Size = new System.Drawing.Size(23, 22);
            this.ToolStripItalic.Text = "Italic";
            this.ToolStripItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // ToolStripUnderline
            // 
            this.ToolStripUnderline.CheckOnClick = true;
            this.ToolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripUnderline.Image")));
            this.ToolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripUnderline.Name = "ToolStripUnderline";
            this.ToolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.ToolStripUnderline.Text = "Underline";
            this.ToolStripUnderline.Click += new System.EventHandler(this.tsUnd_Click);
            // 
            // ToolStripFont
            // 
            this.ToolStripFont.Name = "ToolStripFont";
            this.ToolStripFont.Size = new System.Drawing.Size(121, 25);
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(121, 25);
            // 
            // ToolStripBackgrounColor
            // 
            this.ToolStripBackgrounColor.Name = "ToolStripBackgrounColor";
            this.ToolStripBackgrounColor.Size = new System.Drawing.Size(121, 25);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(-1, 49);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(579, 260);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);
            this.RichTextBox1.TextChanged += new System.EventHandler(this.editor_TextChanged);
            this.RichTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editor_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu,
            this.ToolStripSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnOpen,
            this.mnSave,
            this.mnSaveAs,
            this.mnExit});
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenu.Text = "File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.Size = new System.Drawing.Size(152, 22);
            this.mnNew.Text = "New";
            this.mnNew.Click += new System.EventHandler(this.mnNew_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(152, 22);
            this.mnOpen.Text = "Open";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.Size = new System.Drawing.Size(152, 22);
            this.mnSave.Text = "Save";
            this.mnSave.Click += new System.EventHandler(this.mnSave_Click);
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnSaveAs.Text = "Save As";
            this.mnSaveAs.Click += new System.EventHandler(this.mnSaveAs_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(152, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // ToolStripSetting
            // 
            this.ToolStripSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.ToolStripSetting.Name = "ToolStripSetting";
            this.ToolStripSetting.Size = new System.Drawing.Size(56, 20);
            this.ToolStripSetting.Text = "Setting";
            this.ToolStripSetting.Click += new System.EventHandler(this.mnSetting_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            this.temaToolStripMenuItem.Click += new System.EventHandler(this.temaToolStripMenuItem_Click);
            // 
            // opDialog
            // 
            this.opDialog.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 310);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AldoTaniel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox ToolStripSize;
        private System.Windows.Forms.ToolStripButton ToolStripBold;
        private System.Windows.Forms.ToolStripButton ToolStripItalic;
        private System.Windows.Forms.ToolStripButton ToolStripUnderline;
        private System.Windows.Forms.ToolStripComboBox ToolStripFont;
        private System.Windows.Forms.ToolStripComboBox ToolStripColor;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.SaveFileDialog svDialog;
        private System.Windows.Forms.OpenFileDialog opDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSetting;
        private System.Windows.Forms.ToolStripComboBox ToolStripBackgrounColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
    }
}


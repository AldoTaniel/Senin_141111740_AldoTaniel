namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSize = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripBold = new System.Windows.Forms.ToolStripButton();
            this.ToolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.ToolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFont = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripColor = new System.Windows.Forms.ToolStripComboBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
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
            this.ToolStripColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(403, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripSize
            // 
            this.ToolStripSize.Name = "ToolStripSize";
            this.ToolStripSize.Size = new System.Drawing.Size(75, 25);
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
            this.ToolStripBold.Text = "ToolStripBold";
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
            this.ToolStripItalic.Text = "ToolStripItalic";
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
            this.ToolStripUnderline.Text = "ToolStripUnderline";
            this.ToolStripUnderline.Click += new System.EventHandler(this.tsUnd_Click);
            // 
            // ToolStripFont
            // 
            this.ToolStripFont.Name = "ToolStripFont";
            this.ToolStripFont.Size = new System.Drawing.Size(121, 25);
            this.ToolStripFont.SelectedIndexChanged += new System.EventHandler(this.tsFont_SelectedIndexChanged);
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(121, 25);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(0, 28);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(401, 241);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);
            this.RichTextBox1.TextChanged += new System.EventHandler(this.editor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AldoTaniel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}


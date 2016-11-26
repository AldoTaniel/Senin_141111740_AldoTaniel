using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool simp = true;
        public string filelocation = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection ftFamily = new InstalledFontCollection();
            foreach (FontFamily i in ftFamily.Families)
            {
                ToolStripFont.Items.Add(i.Name);
            }
            ToolStripFont.SelectedIndex = 12;
            for (int i = 5; i <= 72; i++)
            {
                ToolStripSize.Items.Add(i);
            }
            ToolStripSize.SelectedIndex = 12;
            ToolStripFont.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            ToolStripSize.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            ToolStripFont.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ToolStripFont.ComboBox.DrawItem += new DrawItemEventHandler(tsFont_DrawItem);

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                    ToolStripColor.Items.Add(property.Name);
                    ToolStripBackgrounColor.Items.Add(property.Name);
            }
            ToolStripColor.SelectedIndex = 8;
            ToolStripColor.ComboBox.LostFocus += new EventHandler(tsColor_LostFocus);
            ToolStripColor.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_DrawItem);
            ToolStripColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            ToolStripBackgrounColor.Text = "White";
            RichTextBox1.SelectionBackColor = Color.FromName(ToolStripBackgrounColor.Text);
            ToolStripBackgrounColor.ComboBox.LostFocus += new EventHandler(tsBC_LostFocus);
            ToolStripBackgrounColor.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_DrawItem);
            ToolStripBackgrounColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            change();

        }
        public string getBackgroundColor()
        {
            return RichTextBox1.BackColor.Name;
        }

        public void setBackgroundColor(string color)
        {
            RichTextBox1.BackColor = Color.FromName(color);
            RichTextBox1.SelectionBackColor = RichTextBox1.BackColor;
        }
        private void tsFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(ToolStripFont.Items[e.Index].ToString(), new Font(ToolStripFont.Items[e.Index].ToString(), ToolStripFont.Font.Size), Brushes.Black, e.Bounds);

        }
        private void tsColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics grap = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush fbrush = new SolidBrush(e.ForeColor);
                grap.FillRectangle(brush, e.Bounds);
                string s = (string)this.ToolStripColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                fbrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void tsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }
        private void tsColor_LostFocus(object sender, EventArgs e)
        {
            int length = RichTextBox1.SelectionLength;
            int start = RichTextBox1.SelectionStart;
            RichTextBox1.SelectionColor = Color.FromName(ToolStripColor.Text);
            RichTextBox1.Select(start, length);
        }

        private void tsBC_LostFocus(object sender, EventArgs e)
        {
            int length = RichTextBox1.SelectionLength;
            int start = RichTextBox1.SelectionStart;
            RichTextBox1.SelectionBackColor = Color.FromName(ToolStripBackgrounColor.Text);
            RichTextBox1.Select(start, length);
        }
        public void change()
        {
            bool Bold, Italic, Underline;
            int panjang = RichTextBox1.SelectionLength;
            int start = RichTextBox1.SelectionStart;
            float fontSize;
            string fontFamily;
          
            this.RichTextBox1.SelectionChanged -= new System.EventHandler(this.editor_SelectionChanged);
            if (panjang == 0)
            {
                fontFamily = (ToolStripFont.Text == "") ? RichTextBox1.SelectionFont.FontFamily.Name : ToolStripFont.Text;
                fontSize = (ToolStripSize.Text == "") ? RichTextBox1.SelectionFont.Size : Convert.ToSingle(ToolStripSize.Text);
                FontStyle style = (ToolStripBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (ToolStripItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (ToolStripUnderline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                RichTextBox1.SelectionFont = baru;
            }
            for (int i = start; i < start + panjang; i++)
            {
                RichTextBox1.SelectionChanged -= new System.EventHandler(this.editor_SelectionChanged);
                RichTextBox1.Select(i, 1);
                fontFamily = (ToolStripFont.Text == "") ? RichTextBox1.SelectionFont.FontFamily.Name : ToolStripFont.Text;
                fontSize = (ToolStripSize.Text == "") ? RichTextBox1.SelectionFont.Size : Convert.ToSingle(ToolStripSize.Text);

                Bold = RichTextBox1.SelectionFont.Bold;
                Italic = RichTextBox1.SelectionFont.Italic;
                Underline = RichTextBox1.SelectionFont.Underline;

                FontStyle style = (ToolStripBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (ToolStripItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (ToolStripUnderline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                RichTextBox1.SelectionFont = baru;
            }

            RichTextBox1.Select(start, panjang);
            RichTextBox1.Focus();

            this.RichTextBox1.SelectionChanged += new System.EventHandler(this.editor_SelectionChanged);

        }

        private void tsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }
        

        private void tsBold_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsUnd_Click(object sender, EventArgs e)
        {
            change();
        }

        private void editor_SelectionChanged(object sender, EventArgs e)
        {
            ToolStripBold.Checked = false;
            ToolStripItalic.Checked = false;
            ToolStripUnderline.Checked = false;

            if (RichTextBox1.SelectionFont != null)
            {
                try
                {
                    ToolStripFont.SelectedItem = RichTextBox1.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    ToolStripFont.Text = "";
                }

                
                ToolStripSize.Text = RichTextBox1.SelectionFont.Size.ToString();
                

                if (RichTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    ToolStripBold.Checked = true;

                if (RichTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    ToolStripItalic.Checked = true;

                if (RichTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    ToolStripUnderline.Checked = true;
            }
            else
            {
                ToolStripSize.Text = "";
                ToolStripFont.Text = "";
            }

            if (RichTextBox1.SelectionColor.Name == "0")
            {
                ToolStripColor.Text = "Black";
            }
            else
            {
                ToolStripColor.Text = RichTextBox1.SelectionColor.Name;
            }
                ToolStripBackgrounColor.Text = RichTextBox1.BackColor.Name;
        }
        private void tsFont_LostFocus(object sender, EventArgs e)
        {
            change();
        }
        private void save()
        {
            DialogResult fileLoc;
            if (filelocation == "")
            {
                svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                fileLoc = svDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    RichTextBox1.SaveFile(svDialog.FileName);
                    filelocation = svDialog.FileName;
                }
            }
            else
            {
                RichTextBox1.SaveFile(filelocation);
            }
            simp = true;
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult fileLoc;

            svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            fileLoc = svDialog.ShowDialog();
            if (fileLoc == DialogResult.OK)
            {
                RichTextBox1.SaveFile(svDialog.FileName);
                filelocation = svDialog.FileName;
            }

            simp = true;
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }
                fileLoc = opDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    filelocation = opDialog.FileName;
                    simp = true;
                    RichTextBox1.LoadFile(opDialog.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            simp = false;
        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }

                RichTextBox1.Clear();
                filelocation = "";
                simp = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void exit()
        {
            if (!simp)
            {
                DialogResult fileLoc;
                fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (fileLoc == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (fileLoc == DialogResult.Yes)
                {
                    save();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }
        private void tsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = RichTextBox1.SelectionLength;
            int start = RichTextBox1.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            RichTextBox1.SelectionColor = Color.FromName(ToolStripColor.Text);
            RichTextBox1.Focus();
            RichTextBox1.Select(start, length);
        }

        private void tsBC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = RichTextBox1.SelectionLength;
            int start = RichTextBox1.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            RichTextBox1.SelectionBackColor = Color.FromName(ToolStripBackgrounColor.Text);
            RichTextBox1.Focus();
            RichTextBox1.Select(start, length);
        }

        
        private void mnExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                RichTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.SelectionLength == 0)
            {
                return;
            }

            RichTextBox1.SelectedText = "";
        }
        
        private void mnSetting_Click(object sender, EventArgs e)
        {
            
        }
       
        
       
        public void showRTB()
        {
            RichTextBox1.BringToFront();
            RichTextBox1.Focus();
        }

        private void editor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (RichTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
       
        Setting set;
        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (set == null || !set.IsHandleCreated)
            {
                set = new Setting();
                
                set.MdiParent = this;
                set.BringToFront();
                RichTextBox1.SendToBack();
                set.Show();
            }
            else
            {
                set.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit();
        }
    }
}

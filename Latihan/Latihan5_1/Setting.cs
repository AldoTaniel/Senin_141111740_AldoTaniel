using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        

        private void Setting_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    bgColor.Items.Add(color.Name);
                }
            }
            this.bgColor.DrawMode = DrawMode.OwnerDrawFixed;
            this.bgColor.DrawItem += new DrawItemEventHandler(bgColor_DrawItem);
            this.bgColor.Text = frm.getBackgroundColor();
        }
        private void bgColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics grap = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush fbrush = new SolidBrush(e.ForeColor);
                grap.FillRectangle(brush, e.Bounds);
                string s = (string)this.bgColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                fbrush.Dispose();
            }
            e.DrawFocusRectangle();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
            {
                panel1.Visible = true;
            }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.setBackgroundColor(bgColor.Text);
            frm.showRTB();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.showRTB();
            this.Close();
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.showRTB();
        }
    }
}

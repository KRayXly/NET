using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap mbit = new Bitmap(@"1.jpg");
            Graphics g = Graphics.FromImage(mbit);
            pictureBox1.Image = mbit;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                comboBox1.Items.Add(ff.GetName(1));
            comboBox1.SelectedItem = "宋体";
            ColorCmb_Init(comboBox2);
        }
        public void ColorCmb_Init(ComboBox cmb)
        {
            //设置手动绘制
            cmb.DrawMode = DrawMode.OwnerDrawFixed;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            cmb.DrawItem += cmb_DrawItem;
            PropertyInfo[] proInfoList = typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo item in proInfoList)
            {
                cmb.Items.Add(item.Name);
            }
            cmb.Text = "White";
        }
        private void cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index < 0)
                return;

            ComboBox cmb = (ComboBox)sender;

            string colorName = cmb.Items[e.Index].ToString();
            Color color = Color.FromName(colorName);

            SolidBrush brush = new SolidBrush(color);
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;

            rect.Inflate(-2, -2);

            Rectangle rectColor = new Rectangle(rect.Location, new Size(40, rect.Height));
            g.DrawRectangle(new Pen(e.ForeColor), rectColor);
            g.FillRectangle(brush, rectColor);
            g.DrawString(color.Name, new Font("宋体", 9), new SolidBrush(e.ForeColor), (rect.X + 50), rect.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap mbit = new Bitmap(@"1.jpg");
            Graphics g = Graphics.FromImage(mbit);
            Font font = new Font(comboBox1.SelectedItem.ToString(), 100);
            int x, y;
            if (textBox2.Text.Equals(""))
                x = 20;
            else
                x = Convert.ToInt32(textBox2.Text);
            if (textBox3.Text.Equals(""))
                y = 20;
            else
                y = Convert.ToInt32(textBox3.Text);
            string colorName = comboBox2.SelectedItem.ToString();
            Color color = Color.FromName(colorName);

            SolidBrush brush = new SolidBrush(color);
            g.DrawString(textBox1.Text, font, brush, x,y);

            pictureBox1.Image = mbit;
        }
    }
}

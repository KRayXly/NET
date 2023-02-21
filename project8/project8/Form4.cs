using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project8
{
    public partial class Form4 : Form
    {
        float fontsize = 100;
        Font font;
        SolidBrush brush = new SolidBrush(Color.White);
        int x = 20, y = 20;
        int r = 0;
        SizeF size = new SizeF();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bitmap mbit = new Bitmap(@"1.jpg");
            Graphics g = Graphics.FromImage(mbit);
            font = new Font("宋体", this.fontsize);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            g.DrawString("坐标变换", font, brush, x,y);
            this.size = g.MeasureString("坐标变换", font);
            pictureBox1.Image = mbit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap mbit = new Bitmap(@"1.jpg");
            if (textBox1.Text.Equals(""))
                y = y + 0;
            else
                y = y-Convert.ToInt32(textBox1.Text);
            if (textBox2.Text.Equals(""))
                y = y + 0;
            else
                y = y+Convert.ToInt32(textBox2.Text);
            if (textBox3.Text.Equals(""))
                x = x + 0;
            else
                x = x + Convert.ToInt32(textBox3.Text);
            if (textBox4.Text.Equals(""))
                x = x + 0;
            else
                x = x - Convert.ToInt32(textBox4.Text);
            Graphics g = Graphics.FromImage(mbit);
            g.DrawString("坐标变换", font, brush, x, y);
            pictureBox1.Image = mbit;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap mbit = new Bitmap(@"1.jpg");
            Graphics g = Graphics.FromImage(mbit);
            this.size = g.MeasureString("坐标变换", font);
            float wid = this.size.Width;
            
            if (!textBox8.Text.Equals(""))
            {
                wid = wid * Convert.ToInt32(textBox8.Text);
            }
            if (!textBox7.Text.Equals(""))
            {
                wid = wid / Convert.ToInt32(textBox7.Text);
            }
            while ((this.size.Width > wid))
            {
                font.Dispose();
                fontsize -= 0.1f;

                font = new Font("宋体", fontsize);
                this.size = g.MeasureString("坐标变换", font);
            }
            while ((this.size.Width < wid))
            {
                font.Dispose();
                fontsize += 0.1f;

                font = new Font("宋体", fontsize);
                this.size = g.MeasureString("坐标变换", font);
            }
            g.DrawString("坐标变换", font, brush, x, y);
            pictureBox1.Image = mbit;
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Equals(""))
                r += 0;
            else
                r = r + Convert.ToInt32(textBox6.Text);
            if (textBox5.Text.Equals(""))
                r = r + 0;
            else
                r = r - Convert.ToInt32(textBox5.Text);

            Bitmap mbit = new Bitmap(@"1.jpg");
            Graphics g = Graphics.FromImage(mbit);

            g.TranslateTransform(x+this.size.Width/2, y+this.size.Height/2);
            g.RotateTransform(r);
            g.DrawString("坐标变换", font, brush, -this.size.Width / 2, -this.size.Height / 2);
            g.ResetTransform();
            pictureBox1.Image = mbit;
            textBox5.Text = "";
            textBox6.Text = "";
        }
        
    }
}

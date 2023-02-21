using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project8
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(600, 480);
        Pen pen = new Pen(Brushes.Black, 4);
        Pen pen1 = new Pen(Brushes.Black, 6);
        Brush brush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            line();
            tuoyuan(brush);
            jvxing(brush);
        }

        public void line()
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Point p1 = new Point(30, 20);
            Point p2 = new Point(100, 100);
            graphics.DrawLine(pen, p1, p2);
            pictureBox1.Image = bmp;
        }
        public void tuoyuan(Brush brush)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Rectangle[] rect = {
            new Rectangle(188,98,123,188),
             new Rectangle(170,110,123,188)
            };
            Rectangle rectangle1 = new Rectangle(new Point(130, 20), new Size(120, 90));
            graphics.DrawEllipse(pen1, rectangle1);
            graphics.FillEllipse(brush, rectangle1);
            pictureBox1.Image = bmp;
        }
        public void jvxing(Brush brush)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Rectangle rectangle1 = new Rectangle(new Point(290, 20), new Size(60, 80));
            graphics.DrawRectangle(pen1, rectangle1);
            graphics.FillRectangle(brush, rectangle1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Brush brush1 = new SolidBrush(Color.Black);
            line();
            tuoyuan(brush1);
            jvxing(brush1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Brush brush1 = new SolidBrush(Color.White);
            line();
            tuoyuan(brush1);
            jvxing(brush1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Brush brush1 = new SolidBrush(Color.Green);
            line();
            tuoyuan(brush1);
            jvxing(brush1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Brush brush1 = new SolidBrush(Color.Yellow);
            line();
            tuoyuan(brush1);
            jvxing(brush1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Brush brush1 = new SolidBrush(Color.Blue);
            line();
            tuoyuan(brush1);
            jvxing(brush1);
        }
    }
}

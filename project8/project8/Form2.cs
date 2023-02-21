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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pic();
        }

        public void pic()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphic = Graphics.FromImage(bmp);

            SolidBrush Bfill = new SolidBrush(Color.White);
            SolidBrush wfill = new SolidBrush(Color.DarkBlue);
            Pen pen = new Pen(Color.DarkBlue, 3);

            Brush Bbrush = Brushes.Blue;

            Font font = new Font("宋体", 10);
            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            graphic.FillRectangle(Bfill, rect);

            graphic.DrawLine(pen, new Point(40, 30), new Point(40, 220));
            graphic.DrawLine(pen, new Point(40, 30), new Point(35, 40));    
            graphic.DrawLine(pen, new Point(40, 30), new Point(45, 40));
                                                                              
            graphic.DrawLine(pen, new Point(40, 220), new Point(450, 220));
            graphic.DrawLine(pen, new Point(440, 215), new Point(450, 220));
            graphic.DrawLine(pen, new Point(440, 225), new Point(450, 220));

            int x, y, width, heigh;
            x = 45;
            width = 30;
            heigh = 120;
            y = 110;
            int[] num = {20,30,40,60,90,100,70,50,30,20};

            for (int i = 0; i < 10; i++)
            {
                Rectangle rect1 = new Rectangle(x + i * 40, 2*y-num[i], width, num[i]);
                graphic.FillRectangle(wfill, rect1);
                graphic.DrawString(num[i].ToString(), font, Brushes.Black, x + i * 40+5, 2*y - num[i]-15);
            }
            pictureBox1.Image = bmp;
        }
    }
}

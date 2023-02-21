using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertImageToIcon();
        }
        //绘制棋盘
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Image img = Image.FromFile("image/main.gif");
            g.DrawImage(img, 0, 30, 558, 650);
            drawChessMan(e);
        }

        //将原图片修改为ico格式，并修改程序icon
        public void ConvertImageToIcon()
        {
            string origin= "image/红将.gif";
            string destination = "image/icon.ico";
            Size iconSize = new Size(128, 128);

            Image image = new Bitmap(new Bitmap(origin), iconSize); //先读取已有的图片为bitmap，并缩放至设定大小
            MemoryStream bitMapStream = new MemoryStream(); //存原图的内存流
            MemoryStream iconStream = new MemoryStream(); //存图标的内存流
            image.Save(bitMapStream, ImageFormat.Png); //将原图读取为png格式并存入原图内存流
            BinaryWriter iconWriter = new BinaryWriter(iconStream); //新建二进制写入器以写入目标图标内存流

            iconWriter.Write((short)0);
            iconWriter.Write((short)1);
            iconWriter.Write((short)1);
            iconWriter.Write((byte)image.Width);
            iconWriter.Write((byte)image.Height);
            iconWriter.Write((short)0);
            iconWriter.Write((short)0);
            iconWriter.Write((short)32);
            iconWriter.Write((int)bitMapStream.Length);
            iconWriter.Write(22);
            iconWriter.Write(bitMapStream.ToArray());
            iconWriter.Flush();
            iconWriter.Seek(0, SeekOrigin.Begin);
            Stream iconFileStream = new FileStream(destination, FileMode.Create);
            Icon icon = new Icon(iconStream);
            icon.Save(iconFileStream);
            this.Icon = icon;
            iconFileStream.Close();
            iconWriter.Close();
            iconStream.Close();
            bitMapStream.Close();
            icon.Dispose();
            image.Dispose();
        }
        //绘制棋子
        public void drawChessMan(PaintEventArgs e)
        {
            int i,k;
            Image img;
            Graphics g = e.Graphics;
            //黑棋
            img = Image.FromFile("image/黑车.gif");
            for (i = 0, k = 24; i < 2; i++, k += 456)
                g.DrawImage(img, k, 56, 55, 55);          
            img = Image.FromFile("image/黑马.gif");
            for (i = 4, k = 81; i < 6; i++, k += 342)
                g.DrawImage(img, k, 56, 55, 55);
            img = Image.FromFile("image/黑象.gif");
            for (i = 8, k = 138; i < 10; i++, k += 228)
                g.DrawImage(img, k, 56, 55, 55);
            img = Image.FromFile("image/黑士.gif");
            for (i = 12, k = 195; i < 14; i++, k += 114)
                g.DrawImage(img, k, 56, 55, 55);
            img = Image.FromFile("image/黑卒.gif");
            for (i = 16, k = 24; i < 21; i++, k += 114)
                g.DrawImage(img, k, 227, 55, 55);
            img = Image.FromFile("image/黑炮.gif");
            for (i = 26, k = 81; i < 28; i++, k += 342)
                g.DrawImage(img, k, 170, 55, 55);
            img = Image.FromFile("image/黑将.gif");
            g.DrawImage(img, 252, 56, 55, 55);

            //红棋
            img = Image.FromFile("image/红车.gif");
            for (i = 2, k = 24; i < 4; i++, k += 456)
                g.DrawImage(img, k, 569, 55, 55);
            img = Image.FromFile("image/红马.gif");
            for (i = 6, k = 81; i < 8; i++, k += 342)
                g.DrawImage(img, k, 569, 55, 55);
            img = Image.FromFile("image/红象.gif");
            for (i = 10, k = 138; i < 12; i++, k += 228)
                g.DrawImage(img, k, 569, 55, 55);
            img = Image.FromFile("image/红士.gif");
            for (i = 14, k = 195; i < 16; i++, k += 114)
                g.DrawImage(img, k, 569, 55, 55);
            img = Image.FromFile("image/红卒.gif");
            for (i = 21, k = 24; i < 26; i++, k += 114)
                g.DrawImage(img, k, 398, 55, 55);
            img = Image.FromFile("image/红炮.gif");
            for (i = 28, k = 81; i < 30; i++, k += 342)
                g.DrawImage(img, k, 455, 55, 55);
            img = Image.FromFile("image/红将.gif");
            g.DrawImage(img, 252, 569, 55, 55);

        }

        

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p=new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button1, "重新开始一局");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button2, "返回到上次走棋位置");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button3, "退出象棋程序");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}

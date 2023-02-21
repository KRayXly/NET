using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Stage
{
    public partial class Form1 : Form
    {
        //Dockmain frmmain = null;
        Dockbo1 frmbo1 = null;
        Dockbo2 frmbo2 = null;
        Dockleft frmleft = null;
        List<string> strList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //frmmain = new Dockmain();
            //frmmain.Show(dockPanel1);
            frmbo1 = new Dockbo1();
            frmbo1.Show(dockPanel1, DockState.DockBottom);
            frmbo2 = new Dockbo2();
            frmbo2.Show(dockPanel1, DockState.DockBottom);
            frmleft = new Dockleft();
            frmleft.Show(dockPanel1, DockState.DockLeft);
            frmleft.TabText = "图像处理工具";
            frmleft.DockPanel.DockLeftPortion = 0.25;
        }


        private void dockPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //窗口
        private void winleft_Click(object sender, EventArgs e)
        {
            if (frmleft.IsDisposed)
            {
                frmleft = new Dockleft();
                frmleft.Show(dockPanel1, DockState.DockLeft);
            }
                
        }

        private void winbo1_Click(object sender, EventArgs e)
        {
            if (frmbo1.IsDisposed)
            {
                frmbo1 = new Dockbo1();
                frmbo1.Show(dockPanel1, DockState.DockBottom);
            }
        }

        private void winbo2_Click(object sender, EventArgs e)
        {
            if (frmbo2.IsDisposed)
            {
                frmbo2 = new Dockbo2();
                frmbo2.Show(dockPanel1, DockState.DockBottom);
            }
        }
        Dockmain pic = null;
        //按钮
        private void openbt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            openFileDialog1.ShowDialog();
            string[] picturepath = openFileDialog1.FileNames;
            for (int i = 0; i < picturepath.Length; i++)
            {
                Bitmap picture=new Bitmap(picturepath[i]);
                pic=new Dockmain();
                pic.Show(dockPanel1);
                pic.pictureBox1.Image = picture;
                pic.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pic.TabText = Path.GetFileName(picturepath[i]);
            }
            
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }


        private void follow_Click(object sender, EventArgs e)
        {
            //Form frmpic=ActiveMdiChild;
            Form frmpic = ActiveMdiChild;
            frmpic.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Form frmpic = ActiveMdiChild;
            frmpic.Hide();
        }

        //文件
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            openFileDialog1.ShowDialog();
            string[] picturepath = openFileDialog1.FileNames;
            for (int i = 0; i < picturepath.Length; i++)
            {
                Bitmap picture = new Bitmap(picturepath[i]);
                pic = new Dockmain();
                pic.Show(dockPanel1);
                pic.pictureBox1.Image = picture;
                pic.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pic.TabText = Path.GetFileName(picturepath[i]);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}

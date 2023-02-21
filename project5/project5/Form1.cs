using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace project5
{
    public partial class Form1 : Form
    {
        textone one = new textone();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            one.Yingpanrong();
            richTextBox1.Text = "硬盘序列号：\n"+ one.Yingpanxu()
                + "\n硬盘总容量："+ one.totalDiskSize / 1024 / 1024 / 1024+ "GB；\n剩余："
                + one.totalFreeSpace / 1024 / 1024 / 1024+ "GB";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "CPU信息：" + one.CPUmess();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "操作系统：" + one.Caozuo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "内存：" + one.Neicun();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "本机IP地址：" + one.ips();
        }
    }


}

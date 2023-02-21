using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window0930
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("排骨炖白菜");
            listBox1.Items.Add("红烧狮子头");
            listBox1.Items.Add("上海醉蟹");
            listBox1.Items.Add("海带汤");
            listBox1.Items.Add("万峦猪脚");
            listBox1.Items.Add("鸡蛋汤");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem!=null)
                listBox2.Items.Remove(listBox2.SelectedItem);
        }

    }
}

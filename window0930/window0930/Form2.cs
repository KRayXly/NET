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
    public partial class Form2 : Form
    {
        int num = 0;
        internal object rTBDoc;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            this.textBox1.Text = dt.Compute(this.textBox1.Text, "").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str=textBox1.Text;
            textBox1.Text = "";
            int len=str.Length;
            for(int i = 0; i < len - 1; i++)
            {
                textBox1.Text += str[i];
            }
        }
    }
}

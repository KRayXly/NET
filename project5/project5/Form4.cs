using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class Form4 : Form
    {
        textfour four =new textfour();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            if (comboBox1.SelectedIndex == 0)
            {
                label7.Show();
                label2.Hide();
                label12.Hide();
                label5.Hide();
                label6.Hide();
                textBox3.Hide();
                textBox4.Hide();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label7.Hide();
                label2.Show(); 
                label12.Hide();
                label5.Show();
                label6.Hide();
                textBox3.Show();
                textBox4.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label7.Hide();
                label2.Hide();
                label12.Show();
                label5.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                richTextBox1.Text = four.fang1(a, b);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                richTextBox1.Text = four.fang2(a, b, c);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double d = double.Parse(textBox3.Text);
                richTextBox1.Text = four.fang3(a, b, c, d);
            }
        }
    }
}

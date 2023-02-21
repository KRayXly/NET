using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project5
{
    public partial class Form2 : Form
    {
        public int selectindex = 0;
        texttwo two =new texttwo();
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            this.selectindex=comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex==0)
            {
                label2.Show();
                label3.Hide();
                textBox1.Show();
                textBox2.Show();
                textBox4.Show();
                textBox6.Hide();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                label2.Show();
                label3.Hide();
                textBox1.Show();
                textBox2.Hide();
                textBox4.Hide();
                textBox6.Hide();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                label2.Show();
                label3.Hide();
                textBox1.Show();
                textBox2.Hide();
                textBox4.Show();
                textBox6.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label2.Hide();
                label3.Show();
                textBox1.Hide();
                textBox2.Hide();
                textBox4.Hide();
                textBox6.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.selectindex == 0)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double c = double.Parse(textBox4.Text);
                    textBox7.Text = two.sanmian(a,b,c);
                }
            }
            else if (this.selectindex == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    textBox7.Text = two.zhengmian(a);
                }

            }
            else if (this.selectindex == 2)
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox4.Text);
                    textBox7.Text = two.changmian(a,b);
                }
            }
            else if (this.selectindex == 3)
            {
                if (textBox6.Text == "")
                {
                    textBox7.Text = "请输入半径！";
                }
                else
                {
                    double a = double.Parse(textBox6.Text);
                    textBox7.Text = two.yuanmian(a);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.selectindex == 0)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double c = double.Parse(textBox4.Text);
                    textBox7.Text = two.sanzhou(a, b, c);
                }
            }
            else if (this.selectindex == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    textBox7.Text = two.zhengzhou(a);
                }

            }
            else if (this.selectindex == 2)
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox4.Text);
                    textBox7.Text = two.changzhou(a,b);
                }
            }
            else if (this.selectindex == 3)
            {
                if (textBox6.Text == "")
                {
                    textBox7.Text = "请输入半径！";
                }
                else
                {
                    double a = double.Parse(textBox6.Text);
                    textBox7.Text = two.yuanzhou(a);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.selectindex == 0)
            {
                if(textBox1.Text== "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double c = double.Parse(textBox4.Text);
                    if ((a + b) > c && (a + c) > b && (b + c) > a)
                    {
                        textBox7.Text = "三角形的重心是三条中线的交点";
                    }
                    else
                    {
                        textBox7.Text = "不能组成三角形！";
                    }
                }
            }
            else if (this.selectindex == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    textBox7.Text = "正方体的重心是其对角线的交点";
                }
                
            }
            else if (this.selectindex == 2)
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    textBox7.Text = "请输入边长！";
                }
                else
                {
                    textBox7.Text = "长方体的重心是其对角线的交点";
                }
            }
            else if (this.selectindex == 3)
            {
                if (textBox6.Text == "")
                {
                    textBox7.Text = "请输入半径！";
                }
                else
                {
                    textBox7.Text = "圆的重心是其圆心";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

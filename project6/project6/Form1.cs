using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String path = @textBox2.Text;
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "请输入路径！";
            }
            else if (textBox1.Text == "")
            {
                textBox1.Text = "请输入目录名！";
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    if (Directory.Exists(textBox2.Text + @"\" + textBox1.Text))
                    {
                        Directory.Delete(textBox2.Text + @"\" + textBox1.Text);
                    }
                    else
                    {
                        textBox1.Text = "不存在该目录名！";
                    }
                }
                else if(radioButton2.Checked == true)
                {
                    if (Directory.Exists(textBox2.Text + @"\" + textBox1.Text))
                    {
                        textBox1.Text = "已存在该目录名！";
                    }
                    else
                    {
                        Directory.CreateDirectory(textBox2.Text + @"\" + textBox1.Text);
                    }
                    
                }
            }
        }
    }
}

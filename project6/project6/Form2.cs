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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            String path = System.Environment.CurrentDirectory + @"\FILE1";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
                if(!comboBox1.Items.Contains(Path.GetExtension(file)))
                    comboBox1.Items.Add(Path.GetExtension(file));
                
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1\" 
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            if (File.Exists(path))
            {
                label3.Text = "已存在该文件!";
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                Form2_Load(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text= (Path.GetFileNameWithoutExtension(listBox1.SelectedItem.ToString()));
            comboBox1.SelectedItem=(Path.GetExtension(listBox1.SelectedItem.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1\"
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            if (File.Exists(path))
            {
                File.Delete(path);
                Form2_Load(sender, e);
            }
            else
            {
                label3.Text = "不存在该文件!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1\"
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            String path2 = System.Environment.CurrentDirectory + @"\FILE2\"
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            if (File.Exists(path))
            {
                File.Move(path,path2);
                Form2_Load(sender, e);
            }
            else
            {
                label3.Text = "不存在该文件!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1\"
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            String path2 = System.Environment.CurrentDirectory + @"\FILE2\"
                    + textBox1.Text + comboBox1.SelectedItem.ToString();
            if (File.Exists(path))
            {
                File.Copy(path, path2);
                Form2_Load(sender, e);
            }
            else
            {
                label3.Text = "不存在该文件!";
            }
        }
    }
}

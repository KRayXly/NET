using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory + @"\FILE1\" + this.comboBox1.Text;
            if (Path.GetExtension(path) == ".txt")
            {
                string content = string.Empty;
                using (StreamReader reader = new StreamReader(path, UnicodeEncoding.GetEncoding("UTF-8")))
                {
                    content = reader.ReadToEnd();
                    reader.Close();
                }
                richTextBox1.Text = content;
            }
            else if(Path.GetExtension(path) != ".txt")
            {
                richTextBox1.Text = "无法显示非txt文本文件！";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                comboBox1.Items.Add(Path.GetFileName(file));

            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory + @"\FILE1\" + this.comboBox1.Text;
            if (Path.GetExtension(path) == ".txt")
            {
                string content = string.Empty;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(richTextBox1.Text);
                    writer.Flush();
                    writer.Close();
                }
            }
            else if (Path.GetExtension(path) != ".txt")
            {
                richTextBox1.Text = "无法修改非txt文本文件！";
            }
        }
    }
}

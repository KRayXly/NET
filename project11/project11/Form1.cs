using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "https://www.baidu.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");
            if (re.IsMatch(textBox1.Text) == true)
            {
                MessageBox.Show("邮箱正确");
            }
            else
            {
                MessageBox.Show("邮箱错误");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            if (textBox2.Text != "" && re.IsMatch(textBox2.Text.Trim()))
            {
                MessageBox.Show("IP地址正确");
            }
            else
            {
                MessageBox.Show("IP地址错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string InfoUrl = textBox3.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(InfoUrl);
            request.Method = "GET"; request.ContentType = "text/html;charset=UTF-8";
            string XmlString;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream myResponseStream = response.GetResponseStream();
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8))
                {
                    XmlString = myStreamReader.ReadToEnd();
                }
            }
            Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);
            MatchCollection matches = regImg.Matches(XmlString);
            foreach (Match match in matches)
                richTextBox1.Text = match.Groups["imgUrl"].Value+"\n";
        }
    }
}

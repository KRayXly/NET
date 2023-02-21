using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project9
{
    public partial class Form1 : Form
    {
        string xmlPath = Directory.GetCurrentDirectory() + "/fruit.xml";
        XmlDocument xmlDoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            load();
        }
        public void load()
        {
            listBox1.Items.Clear();
            xmlDoc.Load(xmlPath);
            XmlNode name = xmlDoc.DocumentElement.OwnerDocument.DocumentElement;
            foreach (XmlNode node1 in name)
            {
                listBox1.Items.Add(node1.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(xmlPath);
            XmlNode File = xmlDoc.CreateElement(textBox1.Text);
            XmlNode In1=xmlDoc.CreateElement("价格");
            In1.InnerText = textBox2.Text;
            XmlNode In2 = xmlDoc.CreateElement("产地");
            In2.InnerText = textBox3.Text;
            XmlNode In3 = xmlDoc.CreateElement("单位");
            In3.InnerText = textBox4.Text;
            File.AppendChild(In1);
            File.AppendChild(In2);
            File.AppendChild(In3);
            xmlDoc.DocumentElement.AppendChild(File);
            xmlDoc.Save(xmlPath);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(xmlPath);
            if (listBox1.SelectedIndex!=-1)
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem);
                node.SetAttribute("等级", comboBox1.SelectedItem.ToString());
                node.SetAttribute("保质期", comboBox2.SelectedItem.ToString());
                xmlDoc.Save(xmlPath);
                label11.Text = "已添加该属性！";
                load2();
            }
            else
            {
                label11.Text = "请选择水果名！";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load2();
        }
        public void load2()
        {
            listBox2.Items.Clear();
            xmlDoc.Load(xmlPath);
            XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem);
            listBox2.Items.Add("水果名：" + node.Name);
            listBox2.Items.Add("等级：" + node.GetAttribute("等级") + "  保质期：" + node.GetAttribute("保质期"));
            foreach (XmlNode node1 in node)
            {
                listBox2.Items.Add(node1.Name + "：" + node1.InnerText);
            }
            label19.Text=listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(xmlPath);
            String a2 =textBox7.Text;
            String a3 =textBox6.Text;
            String a4 = textBox5.Text;
            String b1 = textBox10.Text;
            String b2 = textBox9.Text;
            if (!a2.Equals(""))
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem+"/"+"价格");
                node.InnerText = a2;
                textBox7.Text="";
            }
            if (!a3.Equals(""))
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem + "/" + "产地");
                node.InnerText = a3;
                textBox6.Text = "";
            }
            if (!a4.Equals(""))
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem + "/" + "单位");
                node.InnerText = a4;
                textBox5.Text = "";
            }
            if (!b1.Equals(""))
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem);
                node.SetAttribute("等级", b1);
                textBox10.Text = "";
            }
            if (!b2.Equals(""))
            {
                XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("水果/" + listBox1.SelectedItem);
                node.SetAttribute("保质期", b2);
                textBox9.Text = "";
            }
            xmlDoc.Save(xmlPath);
            load2();
        }
    }
}

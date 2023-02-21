using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace window0930
{
    public partial class Form4 : Form
    {
        private string title;

        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void o格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void f文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件|*.txt;*.docx;*.doc|所有文件|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                title = openFileDialog1.FileName;
                this.Text = title;
                richTextBox1.Modified = false;
                string ext = title.Substring(title.LastIndexOf(".") + 1);
                ext = ext.ToLower();
                System.IO.FileStream fs = new System.IO.FileStream(title, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.StreamReader sr = new System.IO.StreamReader(fs, Encoding.Default);          
                richTextBox1.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 拷贝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全选StripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            toolStripComboBox2.Items.Clear();
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                toolStripComboBox2.Items.Add(ff.GetName(1));
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.Text, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, Convert.ToSingle(toolStripComboBox1.Text), richTextBox1.SelectionFont.Style);
        }

        private void 文字样式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void 左对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void 右对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void 居中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}

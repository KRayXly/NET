using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace project7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.richTextBox1.Text = "创建线程：\n";
            this.richTextBox2.Text = "线程基本信息：\n";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(LoadData));
            t1.Name = "Task"+ (t1.ManagedThreadId - 2);
            t1.Start();
            this.richTextBox2.AppendText("线程标识符：" + Thread.CurrentThread.ManagedThreadId + "\n");
            this.richTextBox2.AppendText("线程名：" + t1.Name + "\n");
            this.richTextBox2.AppendText("线程状态：" + Thread.CurrentThread.ThreadState + "\n");
            this.richTextBox2.AppendText("线程优先级：" + Thread.CurrentThread.Priority + "\n");
            this.richTextBox2.AppendText("是否为后台程序：" + Thread.CurrentThread.IsBackground + "\n");
        }
        //线程：输出信息
        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text);
            }
        }
        private void LoadData()
        {
            int i = 0;
            while (i < 5)
            {
                SetText("线程" + (Thread.CurrentThread.Name ) + " 消息！\n");
                Thread.CurrentThread.Join(500);
                i++;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

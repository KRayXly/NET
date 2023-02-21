using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project7
{
    public partial class Form1 : Form
    {
        ManualResetEvent th = new ManualResetEvent(false);
        bool stop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(LoadData));
            stop = false;
            th.Set();
            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th.Reset();

            this.richTextBox1.AppendText("暂停中!\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th.Set();
            this.richTextBox1.AppendText("恢复线程！\n");
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
            while (i < 20)
            {
                if (stop)
                {
                    return;
                }
                th.WaitOne();
                SetText("线程" + (Thread.CurrentThread.ManagedThreadId - 2) + " 消息！\n");
                Thread.CurrentThread.Join(500);
                i++;
            }
        }
    }
}

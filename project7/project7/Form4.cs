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

namespace project7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        CountdownEvent latch = new CountdownEvent(10);
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int i = 0;
            ThreadPool.SetMaxThreads(5, 5);

            while (i < 10)
            {
                richTextBox1.AppendText("线程A第" + (i+1) + "次：\n");
                Thread A = new Thread(new ThreadStart(LoadData));
                A.Start();
                while (A.IsAlive) {
                    Application.DoEvents();
                }
                i++;
            }
        }

        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text});
            }
            else
            {
                this.richTextBox1.AppendText(text);
            }
        }
        private void LoadData()
        {
            int key = 0;
            Random random = new Random();
            int num=random.Next(1,6);
            while (key<num)
            {
                SetText("子线程" + (key+1) + "： 消息！\n");
                Thread.CurrentThread.Join(random.Next(100,400));
                key++;
            }
        }
    }
}

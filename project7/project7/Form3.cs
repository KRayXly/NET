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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(LoadData));
            t1.Name = "A";
            t1.Priority = ThreadPriority.Lowest;
            Thread t2 = new Thread(new ThreadStart(LoadData));
            t2.Name = "B";
            t2.Priority = ThreadPriority.Normal;
            Thread t3 = new Thread(new ThreadStart(LoadData));
            t3.Name = "C";
            t3.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();
        }

        delegate void SetTextCallBack(string text,int i,string name);
        private void SetText(string text,int i,string name)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text ,i, name});
            }
            else
            {
                this.richTextBox1.AppendText(text);
                if (i == 4)
                {
                    this.richTextBox2.AppendText(name+" ");
                }
            }
        }
        private void LoadData()
        {
            int i = 0;
            while (i < 5)
            {
                SetText("线程" + Thread.CurrentThread.Name + " 消息！\n",i, Thread.CurrentThread.Name);
                Thread.CurrentThread.Join(500);
                i++;
            }
        }

    }
}

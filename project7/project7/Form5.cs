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
    
    public partial class Form5 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form5()
        {
            InitializeComponent();
            lb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lb.Text = "0%";

            BackgroundWorker m_BgWorker = new BackgroundWorker();

            m_BgWorker.WorkerReportsProgress = true;
            m_BgWorker.WorkerSupportsCancellation = true;
            m_BgWorker.DoWork += DoWork_Handler;
            m_BgWorker.ProgressChanged += ProgressChanged_Handler;
            m_BgWorker.RunWorkerCompleted += RunWorkerCompleted_Handler;

            if (!m_BgWorker.IsBusy)
            {
                m_BgWorker.RunWorkerAsync();

            }
        }

        private void DoWork_Handler(object sender, DoWorkEventArgs args)
        {
            worker = sender as BackgroundWorker;
            StartToWork();
        }
        private void ProgressChanged_Handler(object sender, ProgressChangedEventArgs args)
        {
            //在事件里进行进度条控件操作
            progressBar1.Value = args.ProgressPercentage;
            lb.Text = args.ProgressPercentage.ToString() + "%";
        }
        private void RunWorkerCompleted_Handler(object sender, RunWorkerCompletedEventArgs args)
        {
            this.Close();
        }  

            public void StartToWork()
        {
            Thread.Sleep(1000);
            worker.ReportProgress(10);
            Thread.Sleep(1000);
            worker.ReportProgress(20);
            Thread.Sleep(1000);
            worker.ReportProgress(30);
            Thread.Sleep(1000);
            worker.ReportProgress(40);
            Thread.Sleep(1000);
            worker.ReportProgress(50);
            Thread.Sleep(1000);
            worker.ReportProgress(60);
            Thread.Sleep(1000);
            worker.ReportProgress(70);
            Thread.Sleep(1000);
            worker.ReportProgress(80);
            Thread.Sleep(1000);
            worker.ReportProgress(90);
            Thread.Sleep(1000);
            worker.ReportProgress(100);
        }
    }
}

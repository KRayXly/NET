using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window0930
{
    public partial class Form3 : Form
    {
        Timer timer = new Timer();
        int timeout = 0;
        MouseEventArgs mouseDown;

        public Form3()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (++timeout == 5)//超时5秒弹出信息
            {
                OnMouseLongDown(this.mouseDown);
            }
        }
        //鼠标按下事件
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.mouseDown = e;
            timeout = 0;
            timer.Start();
        }
        //鼠标抬起事件
        protected override void OnMouseUp(MouseEventArgs e)
        {
            timer.Stop();
        }

        protected virtual void OnMouseLongDown(MouseEventArgs e)
        {
            MessageBox.Show("鼠标被长时间按下！");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

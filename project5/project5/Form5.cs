using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class Form5 : Form
    {
        studentInfo[] a=new studentInfo[10];
        studentInfo a1 = new studentInfo("s001", "张三", "软工201班", 0, "浙江杭州");
        studentInfo a2 = new studentInfo("s002", "李四", "软工201班", 1, "浙江温州");
        studentInfo a3 = new studentInfo("s005", "王五", "软工202班", 0, "浙江台州");
        int num = 3;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.a[1] = a1;
            this.a[2] = a2;
            this.a[3] = a3;

            string[] row0 = { a1.Sno,a1.Sname,a1.Sclass,a1.Sex.ToString(),a1.Sfrom};
            dataGridView1.Rows.Add(row0);
            string[] row1 = { a2.Sno, a2.Sname, a2.Sclass, a2.Sex.ToString(), a2.Sfrom };
            dataGridView1.Rows.Add(row1);
            string[] row2 = { a3.Sno, a3.Sname, a3.Sclass, a3.Sex.ToString(), a3.Sfrom };
            dataGridView1.Rows.Add(row2);

            this.a[1].setsc("计算机原理",90,"无");
            this.a[1].setsc("计算机算法", 76, "无");
            this.a[1].setsc("高等数学", 37, "挂科");
            this.a[2].setsc("操作系统", 88, "无");
            this.a[2].setsc("网络安全", 76, "无");
            this.a[3].setsc("网络安全", 67, "缺课");
            this.a[3].setsc("操作系统", 88, "无");
            this.a[3].setsc("高等数学", 76, "无");
            this.a[3].setsc("软件工程", 20, "挂科");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[5].EditedFormattedValue == true)
                {
                    if(a[i + 1].sc >  0)
                    {
                        for (int j = 0; j < a[i+1].sc; j++)
                        {
                            string[] row = { a[i + 1].score[j].Cname, a[i + 1].score[j].Grade.ToString(), a[i + 1].score[j].Cause };
                            dataGridView2.Rows.Add(row);
                        }
                    }
                    else
                    {
                        break;
                    }
                    
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[5].EditedFormattedValue == true)
                {
                    studentInfo b = a[i + 1].ShallowClone();
                    string[] row = { b.Sno, b.Sname, b.Sclass, b.Sex.ToString(), b.Sfrom };
                    dataGridView1.Rows.Add(row);
                    this.num++;
                    this.a[num] = b;
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[5].EditedFormattedValue == true)
                {
                    studentInfo b = a[i + 1].DeepClone();
                    string[] row = { b.Sno, b.Sname, b.Sclass, b.Sex.ToString(), b.Sfrom };
                    dataGridView1.Rows.Add(row);
                    this.num++;
                    this.a[num] = b;
                }

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[5];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    checkCell.Value = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

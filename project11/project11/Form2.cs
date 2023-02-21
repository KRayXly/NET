using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project11
{
    public partial class Form2 : Form
    {
        List<Student> students;
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            students = new List<Student>(){
                new Student { Num = 1, Name = "张三", Age = 18, Grade = 90 },
                new Student { Num = 2, Name = "李四", Age = 20, Grade = 76 },
                new Student { Num = 3, Name = "王五", Age = 17, Grade = 34 },
                new Student { Num = 4, Name = "赵六", Age = 21, Grade = 97 }
            };
            students.ForEach(delegate (Student student)
            {
                listBox1.Items.Add(string.Format("学号：{0},姓名：{1},年龄：{2},成绩：{3}", student.Num, student.Name, student.Age, student.Grade));
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Array = textBox3.Text;
            string[] Splitted = Array.Split(' ');

            if (comboBox1.SelectedIndex==0)
            {
                int[] IntArray = new int[Splitted.Length];
                for (int i = 0; i < Splitted.Length; i++)
                    IntArray[i] = int.Parse(Splitted[i]);
                int val = Convert.ToInt32(textBox4.Text);
                int pos = Find<int>(IntArray,val);
                textBox2.Text = (pos+1).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string val = textBox4.Text;
                int pos = Find<string>(Splitted, val);
                textBox2.Text = (pos + 1).ToString();
            }
            else
            {
                float[] FloatArray = new float[Splitted.Length];
                for (int i = 0; i < Splitted.Length; i++)
                    FloatArray[i] = Convert.ToSingle(Splitted[i]);
                float val = Convert.ToSingle(textBox4.Text);
                int pos = Find<float>(FloatArray, val);
                textBox2.Text = (pos + 1).ToString();
            }
            textBox3.Text = "";
            textBox4.Text = "";
        }
        public int Find<T>(T[] valus, T val)
        {
            for (int i = 0; i < valus.Length; i++)
            {
                if (valus[i].Equals(val))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                students.Sort(new Student_Num_ASC());
                students.ForEach(delegate (Student student)
                {
                    listBox1.Items.Add(string.Format("学号：{0},姓名：{1},年龄：{2},成绩：{3}", student.Num, student.Name, student.Age, student.Grade));
                });
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                students.Sort(new Student_Name_ASE());
                students.ForEach(delegate (Student student)
                {
                    listBox1.Items.Add(string.Format("学号：{0},姓名：{1},年龄：{2},成绩：{3}", student.Num, student.Name, student.Age, student.Grade));
                });
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                students.Sort(new Student_Age_ASE());
                students.ForEach(delegate (Student student)
                {
                    listBox1.Items.Add(string.Format("学号：{0},姓名：{1},年龄：{2},成绩：{3}", student.Num, student.Name, student.Age, student.Grade));
                });
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                students.Sort(new Student_Grade_ASE());
                students.ForEach(delegate (Student student)
                {
                    listBox1.Items.Add(string.Format("学号：{0},姓名：{1},年龄：{2},成绩：{3}", student.Num, student.Name, student.Age, student.Grade));
                });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Array = textBox1.Text;
            string[] Splitted = Array.Split(' ');

            Stack<int> s1 = new Stack<int>(Splitted.Length);
            for (int i = 0; i < Splitted.Length; i++)
                s1.Push(int.Parse(Splitted[i]));
            textBox5.Text = "";
            for (int i = 0; i < Splitted.Length; i++)
                textBox5.Text += s1.Pop().ToString()+" ";
        }
    }
}

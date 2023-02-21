using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace project5
{
    public partial class Form3 : Form
    {
        textthree three=new textthree();
        int[] array = new int[10];
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.array = three.GenerateRandomArray();
            for(int i=0; i< array.Length; i++)
            {
                textBox1.Text = textBox1.Text+" " + array[i];
            }
            textBox2.Text = three.TestSort(three.BubbleSort,array)+"ms";
            textBox3.Text = three.TestSort(three.SelectSort, array) + "ms";
            textBox4.Text = three.TestSort(three.InsertSort, array) + "ms";
            textBox5.Text = three.TestSort(three.QuickSort, array) + "ms";
            int[] array2 = three.returna(array);
            for (int i = 0; i < array2.Length; i++)
            {
                textBox7.Text = textBox7.Text + " " + array2[i];
            }
        }

    }
}

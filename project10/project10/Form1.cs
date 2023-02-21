using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Text;

namespace project10
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        String connetStr = "server=localhost;port=3306;user=root;password=080925; database=net;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = comboBox1.SelectedIndex;
            if (!textBox1.Text.Equals(""))
            {
                if (s == 0)
                {
                    QueryLike("'"+textBox1.Text+"'","name");
                }
                else if (s == 1)
                {
                    QueryLike(textBox1.Text, "age");
                }
                else if (s == 2)
                {
                    QueryLike("'"+textBox1.Text+"'", "sex");
                }
            }
                
            else
                MessageBox.Show("输入的内容不可为空"+ textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            QueryAll();
        }
        private void QueryAll()
        {
            MySqlConnection conn = new MySqlConnection(connetStr);
            string sql = "SELECT * FROM moblie";
            try
            {
                conn.Open();
                //Console.WriteLine("已经建立连接");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                BindingSource bs = new BindingSource();
                bs.DataSource = reader;
                this.dataGridView1.DataSource = bs;

                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "年龄";
                dataGridView1.Columns[3].HeaderText = "性别";
                dataGridView1.Columns[4].HeaderText = "电话";
                dataGridView1.Columns[5].HeaderText = "图片";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                //dataGridView1.RowHeadersVisible = false;
                dataGridView1.RowHeadersWidth = 30;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                reader.Close();
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void QueryLike(string text,string cou)
        {
            MySqlConnection conn = new MySqlConnection(connetStr);
            string sql = string.Format("SElECT * FROM moblie WHERE {0}={1}", cou ,text);
            try
            {
                conn.Open();
                MySqlCommand mcom = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];多了一行
                DataTable dt = ds.Tables[0];
                dt.DefaultView.AllowNew = false;
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message + "\n错误来源：" + err.Source);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = new MySqlConnection(connetStr);
            string sql = string.Format("delete from moblie where id={0}", id);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
                QueryAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message + "\n错误来源：" + err.Source);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string picpath = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (!picpath.Equals(""))
            {
                Bitmap mbit = new Bitmap(picpath);
                Graphics g = Graphics.FromImage(mbit);
                pictureBox1.Image = mbit;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }    
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            QueryAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string age = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string sex = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string photo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Form2 form2 = new Form2(id, name, age, sex, tel, photo);
            form2.ShowDialog();
            QueryAll();
        }
    }
}

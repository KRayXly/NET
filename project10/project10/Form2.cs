using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project10
{
    public partial class Form2 : Form
    {
        private string photo= "";
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        String connetStr = "server=localhost;port=3306;user=root;password=080925; database=net;";

        public Form2()
        {
            InitializeComponent();
            button1.Text = "添加";
        }

        public Form2(string id, string name, string age, string sex, string tel, string photo)
        {
            InitializeComponent();
            this.textBox1.Text = id;
            this.textBox2.Text = name;
            this.textBox3.Text = age;
            this.textBox4.Text = sex;
            this.textBox5.Text = tel;
            this.photo = photo;
            if (!photo.Equals(""))
            {
                Bitmap mbit = new Bitmap(photo);
                Graphics g = Graphics.FromImage(mbit);
                pictureBox1.Image = mbit;
            }
            button1.Text = "修改";
            textBox1.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("添加"))
            {
                load_add();
                this.Close();
            }
            else if (button1.Text.Equals("修改"))
            {
                load_change();
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            openFileDialog1.ShowDialog();
            string picturepath = openFileDialog1.FileName;
            if (!picturepath.Equals(""))
            {
                Bitmap picture = new Bitmap(picturepath);
                pictureBox1.Image = picture;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.photo = picturepath;
                pictureBox1.Image.Save(Path.GetFileName(photo));
            }
                
        }

        private void load_change()
        {
            MySqlConnection conn = new MySqlConnection(connetStr);
            string sql = "update moblie set name = '{0}', age = {1}, sex = '{2}', tel = '{3}', photo = '{4}' where id = {5}";
            
            sql = string.Format(sql, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Path.GetFileName(this.photo),textBox1.Text);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新成功！");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            conn.Close();
        }
        private void load_add()
        {
            MySqlConnection conn = new MySqlConnection(connetStr);
            string sql = "INSERT INTO moblie  VALUES ({0},'{1}',{2},'{3}','{4}','{5}')";
            sql = string.Format(sql, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Path.GetFileName(this.photo));
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}

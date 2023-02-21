using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace project6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory + @"\FILE1\" + this.comboBox1.Text;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(path);

            FileInfo fileInfo = new FileInfo(path);
            double length = Convert.ToDouble(fileInfo.Length);
            double Size = length / 1024 ;
            richTextBox1.Text = "图片内存："+Size.ToString("f2")+"KB\n";

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            System.Drawing.Image upimage = System.Drawing.Image.FromStream(fs);
            int width = upimage.Width;
            int height = upimage.Height;
            richTextBox1.Text = richTextBox1.Text + "图片尺寸：" + width +"×" + height +"\n";

            Image img = Image.FromFile(path);
            PropertyItem[] pt = img.PropertyItems;
            try
            {
                richTextBox1.Text = richTextBox1.Text+ "获取文件EXIF信息：\n长度 i = " + pt.Length.ToString();
                int i = 0;
                for (i = 0; i < pt.Length; i++)
                {
                    richTextBox1.Text = richTextBox1.Text+(string.Format("\r\n i={0}  ID=0x{1:x4} Type={2}  {3}", i, pt[i].Id, pt[i].Type, GetValueStr(pt[i])));
                }
                richTextBox1.Text = richTextBox1.Text + "\nEnd i " + i.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text =(ex.ToString());
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            String path = System.Environment.CurrentDirectory + @"\FILE1";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (Path.GetExtension(file)==".jpg"|| Path.GetExtension(file) == ".png" || Path.GetExtension(file) == ".PNG" || Path.GetExtension(file) == ".jpeg")
                    comboBox1.Items.Add(Path.GetFileName(file));

            }
            comboBox1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private string GetValueStr(PropertyItem pt)
        {
            string reStr = "";
            switch (pt.Type)
            {
                case 1:
                    reStr = GetValueOfType1(pt.Value);
                    break;
                case 2:
                    break;
                case 3:
                    reStr = GetValueOfType3(pt.Value);
                    break;
                case 4:
                    reStr = GetValueOfType4(pt.Value);
                    break;
                case 5:
                    reStr = GetValueOfType5(pt.Value);
                    break;

                default:
                    reStr = " no equal";
                    break;
            }
            return reStr;
        }

        public string GetValueOfType1(byte[] b)
        {
            return System.Text.Encoding.Default.GetString(b);
        }
        public string GetValueOfType2(byte[] b)
        {
            return System.Text.Encoding.ASCII.GetString(b);
        }
        private static string GetValueOfType3(byte[] b)
        {
            if (b.Length != 2) return "Length error";
            return Convert.ToUInt16(b[1] << 8 | b[0]).ToString();
        }
        private static string GetValueOfType4(byte[] b)
        {
            if (b.Length != 4) return "Length error";
            return Convert.ToUInt16(b[3] << 24 | b[2] << 16 | b[1] << 8 | b[0]).ToString();
        }
        private static string GetValueOfType5(byte[] b)
        {
            if (b.Length != 8) return "Length error";
            UInt32 fm, fz;
            fm = 0;
            fz = 0;
            fz = Convert.ToUInt32(b[7] << 24 | b[6] << 16 | b[5] << 8 | b[4]);
            fm = Convert.ToUInt32(b[3] << 24 | b[2] << 16 | b[1] << 8 | b[0]);
            return fm.ToString() + "/" + fz.ToString() + " sec";
        }
        public int getJpgSize(string FileName, out Size JpgSize, out float Wpx, out float Hpx)
        {//C#快速获取JPG图片大小及英寸分辨率
            JpgSize = new Size(0, 0);
            Wpx = 0; Hpx = 0;
            int rx = 0;
            if (!File.Exists(FileName)) return rx;
            FileStream F_Stream = File.OpenRead(FileName);
            int ff = F_Stream.ReadByte();
            int type = F_Stream.ReadByte();
            if (ff != 0xff || type != 0xd8)
            {//非JPG文件
                F_Stream.Close();
                return rx;
            }
            long ps = 0;
            do
            {
                do
                {
                    ff = F_Stream.ReadByte();
                    if (ff < 0) //文件结束
                    {
                        F_Stream.Close();
                        return rx;
                    }
                } while (ff != 0xff);

                do
                {
                    type = F_Stream.ReadByte();
                } while (type == 0xff);

                //MessageBox.Show(ff.ToString() + "," + type.ToString(), F_Stream.Position.ToString());
                ps = F_Stream.Position;
                switch (type)
                {
                    case 0x00:
                    case 0x01:
                    case 0xD0:
                    case 0xD1:
                    case 0xD2:
                    case 0xD3:
                    case 0xD4:
                    case 0xD5:
                    case 0xD6:
                    case 0xD7:
                        break;
                    case 0xc0: //SOF0段
                        ps = F_Stream.ReadByte() * 256;
                        ps = F_Stream.Position + ps + F_Stream.ReadByte() - 2; //加段长度

                        F_Stream.ReadByte(); //丢弃精度数据
                        //高度
                        JpgSize.Height = F_Stream.ReadByte() * 256;
                        JpgSize.Height = JpgSize.Height + F_Stream.ReadByte();
                        //宽度
                        JpgSize.Width = F_Stream.ReadByte() * 256;
                        JpgSize.Width = JpgSize.Width + F_Stream.ReadByte();
                        //后面信息忽略
                        if (rx != 1 && rx < 3) rx = rx + 1;
                        break;
                    case 0xe0: //APP0段
                        ps = F_Stream.ReadByte() * 256;
                        ps = F_Stream.Position + ps + F_Stream.ReadByte() - 2; //加段长度

                        F_Stream.Seek(5, SeekOrigin.Current); //丢弃APP0标记(5bytes)
                        F_Stream.Seek(2, SeekOrigin.Current); //丢弃主版本号(1bytes)及次版本号(1bytes)
                        int units = F_Stream.ReadByte(); //X和Y的密度单位,units=0：无单位,units=1：点数/英寸,units=2：点数/厘米

                        //水平方向(像素/英寸)分辨率
                        Wpx = F_Stream.ReadByte() * 256;
                        Wpx = Wpx + F_Stream.ReadByte();
                        if (units == 2) Wpx = (float)(Wpx * 2.54); //厘米变为英寸
                        //垂直方向(像素/英寸)分辨率
                        Hpx = F_Stream.ReadByte() * 256;
                        Hpx = Hpx + F_Stream.ReadByte();
                        if (units == 2) Hpx = (float)(Hpx * 2.54); //厘米变为英寸
                        //后面信息忽略
                        if (rx != 2 && rx < 3) rx = rx + 2;
                        break;

                    default: //别的段都跳过
                        ps = F_Stream.ReadByte() * 256;
                        ps = F_Stream.Position + ps + F_Stream.ReadByte() - 2; //加段长度
                        break;
                }
                if (ps + 1 >= F_Stream.Length) //文件结束
                {
                    F_Stream.Close();
                    return rx;
                }
                F_Stream.Position = ps; //移动指针
            } while (type != 0xda); // 扫描行开始
            F_Stream.Close();
            return rx;
        }
    }
}

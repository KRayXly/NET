using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4());
            Application.Run(new Form5());
        }
    }

    class textone
    {
        public long totalFreeSpace = 0;
        public long totalDiskSize = 0;
        public string Yingpanxu()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            string sHardDiskSerialNumber = "";
            foreach (ManagementObject mo in searcher.Get())
            {
                sHardDiskSerialNumber = mo["SerialNumber"].ToString().Trim();
                break;
            }
            return sHardDiskSerialNumber;
        }
        public void Yingpanrong()
        {
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            long totalFreeSpace = 0;
            long totalDiskSize = 0;
            foreach (var drive in drives)
            {
                if (drive.IsReady)
                {
                    this.totalFreeSpace += drive.AvailableFreeSpace;
                    this.totalDiskSize += drive.TotalSize;
                }
            }
        }

        public string CPUmess()
        {
            ManagementClass searcher = new ManagementClass("Win32_Processor");
            ManagementObjectCollection mocCPU = searcher.GetInstances();
            string cpum = null;
            foreach (ManagementObject m in mocCPU)
            {
                cpum = cpum + m["Name"].ToString();
            }
            return cpum;
        }

        public string Caozuo()
        {
            ManagementClass searcher = new ManagementClass("Win32_OperatingSystem");
            string sCPUSerialNumber = "";
            ManagementObjectCollection managCollection = searcher.GetInstances();
            foreach (ManagementObject m in managCollection)
            {
                sCPUSerialNumber = m["Name"].ToString();
            }
            return sCPUSerialNumber;
        }

        public string Neicun()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher();
            searcher.Query = new SelectQuery("Win32_PhysicalMemory", "", new string[] { "Capacity" });
            ManagementObjectCollection collection = searcher.Get();
            ManagementObjectCollection.ManagementObjectEnumerator em = collection.GetEnumerator();
            long capacity = 0;
            while (em.MoveNext())
            {
                ManagementBaseObject baseObj = em.Current;
                if (baseObj.Properties["Capacity"].Value != null)
                {
                    capacity += long.Parse(baseObj.Properties["Capacity"].Value.ToString());
                }
            }
            return capacity / 1024 / 1024 / 1024 + "GB";
        }

        public string ips()
        {
            string IPv4Str = "";
            ManagementClass searcher = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection managementObject = searcher.GetInstances();
            foreach (ManagementBaseObject managementBaseObject in managementObject)
            {
                ManagementObject management1 = (ManagementObject)managementBaseObject;
                if (!(bool)management1["IPEnabled"]) continue;
                Array array = (Array)(management1.Properties["IpAddress"].Value);
                IPv4Str = array.GetValue(0).ToString();
                break;
            }
            return IPv4Str;
        }
    }

    class texttwo{
        public string sanmian(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                double p = (a + b + c) / 2;
                return (Math.Sqrt(p * (p - a) * (p - c) * (p - b))).ToString();
            }
            else
            {
                return  "不能组成三角形！";
            }
        }

        public string sanzhou(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                double p = (a + b + c) / 2;
                return (a + b + c).ToString();
            }
            else
            {
                return "不能组成三角形！";
            }
        }

        public string zhengmian(double a)
        {
            return (a * a).ToString();
        }
        public string zhengzhou(double a)
        {
            return (a * 4).ToString();
        }

        public string changmian(double a,double b)
        {
            return (a * b).ToString();
        }
        public string changzhou(double a,double b)
        {
            return ((a + b) * 2).ToString() ;
        }

        public string yuanmian(double a)
        {
            return (3.1415926 * a * a).ToString("f4");
        }
        public string yuanzhou(double a)
        {
            return (3.1415926 * a * 2).ToString("f4");
        }
    }

    class textthree
    {
        public int[] GenerateRandomArray()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random(Guid.NewGuid().GetHashCode()).Next(1, 1000);
            }
            return array;
        }
        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int insertIndex = i;
                if (array[i] < array[0])
                {
                    insertIndex = 0;
                }
                else
                {
                    for (int j = 0; j + 1 < i; j++)
                    {
                        if (array[j] < array[i] && array[i] <= array[j + 1])
                        {
                            insertIndex = j + 1;
                            break;
                        }
                    }
                }
                int temp = array[i];
                for (int j = i; j > insertIndex; j--)
                {
                    array[j] = array[j - 1];
                }
                array[insertIndex] = temp;
            }
        }
        public void QuickSort(int[] array)
        {
            PartialSort(array, 0, array.Length - 1);
        }

        public void PartialSort(int[] array, int fromIndex, int toIndex)
        {
            if (toIndex <= fromIndex)
                return; 
            int splitIndex = GetPartialIndex(array, fromIndex, toIndex);
            PartialSort(array, fromIndex, splitIndex - 1);
            PartialSort(array, splitIndex + 1, toIndex);
        }
        public int GetPartialIndex(int[] array, int fromIndex, int toIndex)
        {
            int pivotValue = array[fromIndex];
            while (fromIndex < toIndex)
            {
                while (fromIndex < toIndex && pivotValue < array[toIndex])
                {
                    toIndex--;
                }
                array[fromIndex] = array[toIndex];
                while (fromIndex < toIndex && array[fromIndex] < pivotValue)
                {
                    fromIndex++;
                }
                array[toIndex] = array[fromIndex];
            }

            array[fromIndex] = pivotValue;
            return toIndex;
        }

        public double TestSort( Action<int[]> actionSort, int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            actionSort(array);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
        public int[] returna(int[] array)
        {
            QuickSort(array);
            return array;
        }

    }

    class textfour
    {
        public string fang1(double a, double b)
        {
            return (-b / a).ToString("f2");
        }
        public string fang2(double a, double b, double c)
        {
            if (a == 0)
            {
                return "这不是一个一元二次方程";
            }
            else
            {
                double x, y, z, i;
                b = b / a; c = c / a; a = a / a;
                i = (b / 2) * (b / 2);
                z = Math.Sqrt(a);
                x = -(b / 2) / z;
                y = Math.Sqrt((c - i) * (c - i));
                y = Math.Sqrt(y) / z;
                if (c - i <= 0)
                {
                    if (y == 0)
                    {
                        return "x1 = x2 = " + (x + y).ToString("f2");
                    }
                    else
                    {
                        return "x1 = " + (x + y).ToString("f2") + " , x2 = " + (x - y).ToString("f2");
                    }
                }
                else
                {
                    return "x1 = " + x.ToString("f2") + "i , x2 = " + y.ToString("f2") + "i";
                }
            }
        }
        public string fang3(double a, double b, double c, double d)
        {
            double x1, x2, x3, p, q, i, w, s1, s2, s3, X2, X3;
            string re = "";
            p = (3 * a * c - b * b) / (3 * a * a);
            q = (27 * a * a * d - 9 * a * b * c + 2 * b * b * b) / (27 * a * a * a);
            w = -0.5;
            s1 = -b / (3 * a);
            if (-q / 2 + Math.Sqrt(q * q / 4 + p * p * p / 27) > 0)
            {
                s2 = Math.Pow((-q / 2 + Math.Sqrt(q * q / 4 + p * p * p / 27)), 1.0 / 3);
            }
            else
            {
                s2 = -Math.Pow(-(-q / 2 + Math.Sqrt(q * q / 4 + p * p * p / 27)), 1.0 / 3);
            }
            if (-q / 2 - Math.Sqrt(q * q / 4 + p * p * p / 27) > 0)
            {
                s3 = Math.Pow((-q / 2 - Math.Sqrt(q * q / 4 + p * p * p / 27)), 1.0 / 3);
            }
            else
            {
                s3 = -Math.Pow(-(-q / 2 - Math.Sqrt(q * q / 4 + p * p * p / 27)), 1.0 / 3);
            }
            x1 = s1 + s2 + s3;
            x2 = s1 + w * s2 + w * s3;
            X2 = Math.Sqrt(3) / 2 * s2 + (-Math.Sqrt(3) / 2) * s3;
            x3 = s1 + w * s2 + w * s3;
            X3 = Math.Sqrt(3) / 2 * s3 + (-Math.Sqrt(3) / 2) * s2;
            re="x1 = "+x1.ToString("f2");
            if (X2 > 0)
            {
                re += " , x2 ="+x2.ToString("f2")+ " + "+X2.ToString("f2")+"i";
            }
            else
            {
                re += " , x2 =" + x2.ToString("f2")+ X2.ToString("f2") + "i";
            }
            if (X3 > 0)
            {
                re += " , x3 =" + x3.ToString("f2") + " + " + X3.ToString("f2") + "i";
            }
            else
            {
                re += " , x3 =" + x3.ToString("f2") + X3.ToString("f2") + "i";
            }
            return re;
        }
    }

    class studentInfo
    {
        public int sc = 0;
        public string Sno { get; set; }
        public string Sname { get; set; }

        public string Sclass { get; set; }

        public int Sex { get; set; }
        public string Sfrom { get; set; }
        public Score[] score=new Score[5];

        public void setsc(string sno,int grade,string cause)
        {
            Score a = new Score(sno, grade, cause);
            score[this.sc] = a;
            this.sc++;
        }


        public studentInfo(string sno, string sname, string sclass, int sex,string sfrom)
        {
            this.Sno = sno;
            this.Sname = sname;
            this.Sclass = sclass;
            this.Sex = sex;
            this.Sfrom = sfrom;
        } 
        //浅拷贝
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public studentInfo ShallowClone()
        {
            return Clone() as studentInfo;
        }

        //深拷贝
        public studentInfo DeepClone()
        {
            studentInfo clone = new studentInfo(this.Sno, this.Sname, this.Sclass, this.Sex, this.Sfrom);
            clone.sc= this.sc;
            for(int i = 0; i < this.sc; i++)
            {
                clone.score[i]= this.score[i];
            }
            return clone;
        }

    }
    public  class Score {
        public string Cname { get; set; }
        public int Grade { get; set; }
        public string Cause { get; set; }
        public Score( string cname, int grade, string cause)
        {
            this.Cname = cname;
            this.Grade = grade;
            this.Cause = cause;
        }
    }

}


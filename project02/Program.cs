// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
//1.
Console.Write("1. 请输入字符串：");
String str = Console.ReadLine();
char[] key = str.ToCharArray();
int len = str.Length;
for (int i = 0; i < len; i++)
{
    putchar(key[i]);
}

void putchar(char a)
{
    if (a >= 'a' && a < 'z')
    {
        Console.WriteLine("{0} : 小写字母", a);
    }
    else if (a >= 'A' && a <= 'Z')
    {
        Console.WriteLine("{0} : 大写字母", a);
    }
    else if (a >= '0' && a <= '9')
    {
        Console.WriteLine("{0} : 数字", a);
    }
    else
        Console.WriteLine("{0} : 其它符号", a);
}

Console.WriteLine();
//2.
DateTime beginTime = DateTime.Now;
int j, n = 100000, k = 0;
for (int i = 3; i <= n; i += 2)
{
    for (j = 2; j < (Math.Sqrt(i) + 1); j++)
    {
        if (i % j == 0) break;
    }
    if (j > Math.Sqrt(i)) k++;
}
Console.WriteLine("2. 1~100000之间的素数有：{0}个", k);

DateTime endTime = DateTime.Now;
TimeSpan oTime = endTime.Subtract(beginTime);

Console.WriteLine("计算运行时间：{0} 毫秒", oTime.TotalMilliseconds);

Console.WriteLine();
//3
//3.1 日照香炉生紫烟，遥看瀑布挂前川。飞流直下三千尺，疑是银河落九天。
Console.Write("3.1. 请输入古诗：");
String str1 = Console.ReadLine();
char[] key1 = str1.ToCharArray();
int len1 = str1.Length;
for (int i = 0; i < len1; i++)
{
    if (key1[i] == '，' || key1[i] == '。')
    {
        Console.Write("{0}\n", key1[i]);
    }
    else
        Console.Write("{0}  ", key1[i]);
}

Console.WriteLine();
//3.2
Console.WriteLine("3.2.");
DateTime dt = DateTime.Now;
string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
string[] Mon = new string[] { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" };
string[] Hour = new string[] { "上午", "下午" };
string week = Day[Convert.ToInt32(dt.DayOfWeek.ToString("d"))].ToString();
string month = Mon[Convert.ToInt32(dt.ToString("MM"))].ToString();
int hourkey = 1;
int hour = Convert.ToInt32(dt.ToString("hh"));
if (hour >= 12)
{
    hourkey = 2;
    hour -= 12;
}

Console.WriteLine(string.Format("当前日期为：{0:d}", dt));
Console.WriteLine(string.Format("当前日期为：{0:D}", dt));
Console.WriteLine(string.Format("当前时间为：{0:t}", dt));
Console.WriteLine(string.Format("当前时间为：{0:T}", dt));
Console.WriteLine(string.Format("当前日期时间为：{0:f}", dt));
Console.WriteLine(string.Format("当前日期时间为：{0:F}", dt));
Console.WriteLine(string.Format("当前日期时间为：{0:G}", dt));
Console.WriteLine(string.Format("当前日期时间为：{0:g}", dt));
Console.WriteLine(string.Format("当前月日为：{0:M}", dt));
Console.WriteLine(string.Format("当前年月为：{0:Y}", dt));
Console.WriteLine(string.Format("当前日期为：{0:yy年MM月dd日}", dt));
Console.WriteLine(string.Format("当前日期为：" + dt.Year.ToString() + "年" + month + "月" + dt.ToString("dd") + "日" + week));
Console.WriteLine(string.Format("当前时间为：" + Hour[hourkey] + hour + "点" + dt.ToString("mm") + "分" + dt.ToString("ss") + "秒"));

Console.WriteLine();
//4.
Console.WriteLine("4.请输入IP地址：");
String str2 = Console.ReadLine();
while (!ipJudge(str2))
{
    Console.WriteLine("IP地址格式错误！");
    Console.WriteLine("请输入IP地址：");
    str2 = Console.ReadLine();
}
Console.WriteLine("IP地址格式正确！");
static bool ipJudge(string ipAddress)
{
    Regex validipregex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
    return (ipAddress != "" && validipregex.IsMatch(ipAddress.Trim())) ? true : false;
}
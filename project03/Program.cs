// See https://aka.ms/new-console-template for more information

//1.周八 吴九
Console.WriteLine("1. ");
string[] namelist = new string[] { "张三", "李四", "王五", "赵六", "孙七", "周八" };
for (int c = 0; c < 6; c++)
{
    if (c < 5)
    {
        Console.Write(namelist[c] + " ");
    }
    else
    {
        Console.WriteLine(namelist[c]);
    }

}
Console.Write("将 ");
String str1 = "";
for (int w = 0; w < 2; w++)
{
    str1 = str1 + Convert.ToChar(Console.ReadKey().KeyChar);
}
Console.Write(" 改名为 ");
String str2 = Console.ReadLine();

for (int j = 0; j < 6; j++)
{
    if (namelist[j] == str1)
    {
        namelist[j] = str2;
        if (j < 5)
        {
            Console.Write(namelist[j] + " ");
        }
        else
        {
            Console.WriteLine(namelist[j]);
        }
    }
    else
    {
        if (j < 5)
        {
            Console.Write(namelist[j] + " ");
        }
        else
        {
            Console.WriteLine(namelist[j]);
        }
    }
}

Console.WriteLine();
//2.
Console.WriteLine("2. ");
Dictionary<string, int> dict = new Dictionary<string, int>();
string[] dilist = new string[] { "河北省", "山西省", "江苏省" };
dict.Add("石家庄市", 1);
dict.Add("唐山市", 1);
dict.Add("太原市", 2);
dict.Add("大同市", 2);
dict.Add("南京市", 3);
dict.Add("苏州市", 3);
for (int k = 0; k < 3; k++)
{
    Console.WriteLine(dilist[k] + ":");
    foreach (KeyValuePair<string, int> kvp in dict)
    {
        if (kvp.Value == (k + 1))
        {
            Console.WriteLine("        " + kvp.Key);
        }
    }
}
Console.WriteLine("请输入需要查询的省份：");
String str3 = Console.ReadLine();
str3 = str3 + "省";
for (int h = 0; h < 3; h++)
{
    if (dilist[h].Equals(str3))
    {
        foreach (KeyValuePair<string, int> kvp in dict)
        {
            if (kvp.Value == (h + 1))
            {
                Console.WriteLine("        " + kvp.Key);
            }
        }
    }
}

Console.WriteLine();
//3.
Console.WriteLine("3. ");
Console.WriteLine("学号  高数  c语言 英语");
int[,] grade = new int[20, 4];
Random r = new Random();
for (int a = 0; a < 20; a++)
{
    grade[a, 0] = a;
    Console.Write(string.Format("{0,-5} ", grade[a, 0]));
    for (int j = 1; j < 4; j++)
    {
        grade[a, j] = r.Next(100);
        Console.Write(string.Format("{0,-5} ", grade[a, j]));
    }
    Console.WriteLine();
}

Console.WriteLine();
//4.
//<a+[b*c/(d-1)]/[(a+b)/<c+d>]>
Console.WriteLine("4. ");
Console.WriteLine("请输入带括号的表达式：");
String str4 = Console.ReadLine();
if (isbra(str4))
{
    Console.WriteLine("表达式括号格式正确！");
}
else
{
    Console.WriteLine("表达式括号格式错误！");
}
bool isbra(string str)
{
    int num = 0;
    List<int> numList = new List<int>();
    for (int i = 0; i < str.Length; i++)
    {
        num = 0;
        switch (str[i])
        {
            case '<':
                num = 4;
                break;
            case '{':
                num = 3;
                break;
            case '[':
                num = 2;
                break;
            case '(':
                num = 1;
                break;
            case '>':
                num = -4;
                break;
            case '}':
                num = -3;
                break;
            case ']':
                num = -2;
                break;
            case ')':
                num = -1;
                break;
            default:
                break;
        }
        if (num > 0)
        {
            numList.Add(num);
        }
        if (num < 0)
        {
            if (numList[numList.Count - 1] + num == 0)
            {
                numList.RemoveAt(numList.Count - 1);
            }
            else
            {
                return false;
            }

        }
    }
    if (numList.Count == 0)
        return true;
    else
        return false;
}

Console.WriteLine();
//5.
Console.WriteLine("5. ");
Random r1 = new Random();
int guessnum = r1.Next(1000);
Console.WriteLine("甲：目标值{0}", guessnum);
int lastmin = 0, lastmax = 1000, i = 1;
int youguess = (lastmax + lastmin) / 2;
Console.WriteLine("第{0}次：猜数{1}", i, youguess);
while (youguess != guessnum)
{
    if (youguess > guessnum)
    {
        Console.WriteLine("大于目标值");
        lastmax = youguess;
        youguess = (lastmax + lastmin) / 2;
        i++;
        Console.WriteLine("第{0}次：猜数{1}", i, youguess);
    }
    else if (youguess < guessnum)
    {
        Console.WriteLine("小于目标值");
        lastmin = youguess;
        youguess = (lastmax + lastmin) / 2;
        i++;
        Console.WriteLine("第{0}次：猜数{1}", i, youguess);
    }
}
Console.WriteLine("等于目标值");


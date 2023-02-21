// See https://aka.ms/new-console-template for more information
//Console.WriteLine(".Net 第一次测试！！");
double a = 0, b = 0, c = 0;
double area = 0;
try
{
    Console.WriteLine("输入三角形第一条边：");
    String s = Console.ReadLine();
    a = double.Parse(s);
    Console.WriteLine("输入三角形第二条边：");
    s = Console.ReadLine();
    b = double.Parse(s);
    Console.WriteLine("输入三角形第三条边：");
    s = Console.ReadLine();
    c = double.Parse(s);
}
catch
{
    Console.WriteLine("输入错误");
}
if ((a + b) > c && (a + c) > b && (b + c) > a)
{
    double s = (a + b + c) / 2;
    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    Console.WriteLine("边长a={0},b={1},c={2}的三角形面积为{3}。", a, b, c, area);
}
else
{
    Console.WriteLine("不能构成三角形");
}

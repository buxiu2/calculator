using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        public static bool Equals(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {        
            Add add = new Add();
            Subtract subtract = new Subtract();
            Multiply multiply = new Multiply();
            Divide divide = new Divide();
            int a, b;
            string x, y;
            Console.WriteLine("请选择要进行的运算(序号)：1.+  2.-  3.*  4./");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:Console.WriteLine("请选择（序号）：1.两个整数运算  2.两个字符串运算");
                    int d =int.Parse(Console.ReadLine());
                    if (d == 1)
                    {
                        Console.WriteLine("请输入两个数：");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        add.AjiaB(a, b);
                    }
                    else
                    {
                        Console.WriteLine("请输入两个字符串：");
                        x = Console.ReadLine();
                        y = Console.ReadLine();
                        add.AjiaB(x, y);
                    }
                    break;
                case 2: Console.WriteLine("请选择（序号）：1.两个整数运算  2.两个字符串运算");
                    int z = int.Parse(Console.ReadLine());
                    if (z == 1)
                    {
                        Console.WriteLine("请输入两个数：");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        subtract.AjianB(a, b);
                    }
                    else
                    {
                        Console.WriteLine("请输入两个字符串：");
                        x = Console.ReadLine();
                        y = Console.ReadLine();
                        subtract.AjianB(x, y);
                    }
                    break;
                case 3: Console.WriteLine("请输入两个数：");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine()); 
                    multiply.AchengB(a, b); break;
                case 4: Console.WriteLine("请输入两个数：");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine()); 
                    divide.AchuB(a, b); break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Divide
    {
        public void AchuB(int a, int b)
        {
            while(true)
            {
                if (b == 0)
                {
                    Console.WriteLine("两个数相除除数不能为0，请重新输入！");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("结果为: {0}", (double)a / b);
                    break;
                }
            }
        }
    }
}

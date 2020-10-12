using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Subtract
    {
        public void AjianB(int a, int b)
        {
           Console.WriteLine("结果为: {0}",a - b);
        }
        public void AjianB(string a, string b)
        {
            Regex r=new Regex(b);
            Console.WriteLine("结果为：{0}",r.Replace(a,""));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    /// <summary>
    /// 命名空间摘要
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a;//单行注释变量赋值
            a = 998;
            double b;
            /*多行注释
             * 用于比较详细的说明
             */
            b = 3.1415926;
            char c;
            c = 'D';
            string d;
            d = "好事多磨，慢慢学，积累够了自然会用";
            int e, f, g;
            e = 1099; f = 2099; g = 9999;
            string h = "刚开始学只能搞点这些简单的东西";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入交互
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("可以键盘输入文字以便交互：");
                     input = Console.ReadLine();
            Console.WriteLine("你的问题是：{0}",input);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("任意输入字符，看看人机交互：");
            string input = Console.ReadLine();
            Console.WriteLine("\"{0}\",成功得到回应，虽然看起来是交互了，\n但实际上没有达到真正的要求，不过入\b门了就是开始。",input);                    
            Console.WriteLine("临\t兵\t斗\t者\t皆\t阵\t列\t在\t前");
            Console.WriteLine("Lin\tBing\tDou\tZhe\tJie\tZhen\tLie\tZai\tQian");
            Console.ReadKey();

        }
    }
}

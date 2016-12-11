using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("任意输入一个数字：");
            //string FiNum = Console.ReadLine();
            //int FirstNum = Convert.ToInt32(FiNum);
            //Console.WriteLine("再任意输入一个数字：");
            //string SeNum = Console.ReadLine();
            //int SecondNum = Convert.ToInt32(SeNum);

            //Console.WriteLine("两个数字的和是:{0},取余数是{1}。",FirstNum + SecondNum,FirstNum%SecondNum);
            //Console.ReadKey();



            //try
            //{ 
            //    Console.WriteLine("任意输入一个数字：");
            //    string FiNum = Console.ReadLine();
            //    int FirstNum = Convert.ToInt32(FiNum);
            //    Console.WriteLine("再任意输入一个数字：");
            //    string SeNum = Console.ReadLine();
            //    int SecondNum = Convert.ToInt32(SeNum);
            //    Console.WriteLine("两个数字的和是:{0}。,积是{1}，商是{2}，余数是{3}，平均数是{4}",FirstNum + SecondNum,
            //        FirstNum * SecondNum, FirstNum / SecondNum, FirstNum % SecondNum, ( FirstNum + SecondNum)/2);
            //    Console.ReadKey();
            //}
            //catch
            //{
            //    Console.WriteLine("只能输入数字，请重新运行。");

            //}




            //Console.Write("上面的程序写的比较复杂,现在换一种姿势？");
            //Console.WriteLine("撸入第一个新的数字：");
            //int Num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("撸入第二个新的数字：");
            //int Num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("这就是新的两个数字的和{0}。",Num+Num2);
            //Console.ReadKey();



            //天换算月、周、剩余天
            //Console.WriteLine("任意输入一个数字：");
            //int days = Convert.ToInt32(Console.ReadLine()),
            //    month = days / 30, week = days / 7, mod = days % 7;
            //Console.WriteLine("这个数字{0}可以包含{1}个月{2}周零{3}天。",days,month,week,mod);
            //Console.ReadKey();

            //秒换算成分、时、天(这教程没声音了，后面部分没看懂,写出来的计算完全有问题)
            Console.WriteLine("任意输入一个秒数：");
            int seconds = Convert.ToInt32(Console.ReadLine());
            //int seconds = 107653;
            int days = seconds / (3600 * 24),//天
            mod = seconds % (3600 * 24);
            int hour = mod % 3600,//小时
            mods = mod % 3600,
            min = mod / 60,//分钟
            second = mod % 60;//秒
            Console.WriteLine("{0}中包含了{1}天{2}小时{3}分钟{4}秒,{5}。",seconds,days,hour,min,second,mods);
            Console.ReadKey();






        }
    }
}

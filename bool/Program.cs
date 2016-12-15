using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Num1 =10, Num2 = 90;
            ////bool No2 = Num1 <= 9 && Num2 <= 100;
            //bool No2 = Num1 <=9 || Num2 <= 100;
            //Console.WriteLine(No2);



            //Console.Write("输入语文成绩：");
            //int Chn = Convert.ToInt32(Console.ReadLine());
            //Console.Write("输入英语成绩：");
            //int Eng = Convert.ToInt32(Console.ReadLine());
            //bool result = Chn >= 90 && Eng >= 90;
            //bool result2 = Chn >= 90 || Eng >= 90;
            //Console.WriteLine("\"我的成绩都超过了90分\"，是真的吗？{0}，\"其中有一门成绩超过了90分是真的吗？\"{1}",result,result2);

            //Console.WriteLine("输入一个年份，看是否闰年。");
            //int year = Convert.ToInt32(Console.ReadLine());

            //bool result = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
            //Console.WriteLine("这一年{0}",result);
            //

            int Num1 = 6, Num2 = 11; Num1+=5;
            //bool result = ++Num1>50 && ++Num2 > 3;
            bool result = ++Num1 < 50 || ++Num2 > 3;
            Console.WriteLine("Num1={0},Num2={1}",Num1,Num2);
            Console.ReadKey();
        }
    }
}

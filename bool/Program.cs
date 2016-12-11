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
            
           

            Console.Write("输入语文成绩：");
            int Chn = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入英语成绩：");
            int Eng = Convert.ToInt32(Console.ReadLine());
            bool result = Chn >= 90 || Eng >= 90;
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }
}

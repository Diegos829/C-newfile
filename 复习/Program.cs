using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //double pi = 3.14; 
            //int r = 7;
            //double s = pi * r;
            //Console.WriteLine("面积等于{0}",s);
            //int num1 = 159;
            //int num2 = 260;
            //int num3 = 505;
            //int sum = num1 + num2 + num3;
            //int avg = sum / 3;
            //double plus = num1 * num2 * num3;
            //Console.WriteLine("三个数分别是{0}、{1}、{2}，它们的和是{3}，平均数是{4}，积是{5}。",num1,num2,num2,sum,avg,plus);
            //Console.ReadKey();

            //int ts = 35;
            //double kz= 120;
            //double zj = 3 * ts + 2 * kz;
            //double zkj = zj * 0.88;
            //Console.WriteLine("T恤单价{0}，裤子单价{1}，买3件T恤，2条裤子，总价是{2}，如果按8.8折计算,只需付{3}。",ts,kz,zj,zkj);
            //Console.ReadKey();

            int num1 = 10, num2 = 3;
            int mod = num1 % num2;
            double quo = num1 / num2;
            double quo2 = num1 * 1.0 / num2;
            Console.WriteLine("mod={0},quo={1},quo2={2}", mod, quo, quo2);
            Console.ReadKey();
        }
    }
}

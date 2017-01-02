using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            // test 1
            //int i = 1;
            //    while(i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("i={0}", i);
            //Console.ReadKey();

            //test 2
            //Console.WriteLine("input a number:");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //while (Number < 60)
            //{
            //    Console.WriteLine("大于{0}是{1}", Number,Number+1);
            //    Number++;
            //}
            //Console.WriteLine(Number);
            //Console.ReadKey();

            // test 3
            //Console.WriteLine("input a number:");
            //int Count = Convert.ToInt32(Console.ReadLine());//定义一个循环范围
            //int i = 0;
            //int score =0;//每次输入的数字
            //int sum = 0;//和
            //while (i < Count)
            //{
            //    Console.WriteLine("input{0}",i+1);
            //    score = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + score;//sum和+输入的数字；
            //    i++;
            //}
            //Console.WriteLine("{0},{1},{2}",Count,sum,sum/Count);
            //Console.ReadKey();

            //test 4
            //Console.WriteLine("Do u understand?(input y/n)");
            //string answer = Console.ReadLine();
            //int i = 0;
            //while (answer == "n"&&i<4)
            //{
            //    Console.WriteLine("Do u understand?(input y/n)");
            //    i++;
            //    answer = Console.ReadLine();
            //}
            //Console.WriteLine("okay while out");
            //Console.ReadKey();

            //test 5
            Console.WriteLine("今年￥8000,每年增加25%，哪年能达到￥200000？");
            int year = 2017;
            double money = 80000;
            
            while(money<=200000)
            { 
            money=money*1.25;
                year++;
                
            }
            Console.WriteLine(year);
          
            Console.ReadKey();
        }
    }
}

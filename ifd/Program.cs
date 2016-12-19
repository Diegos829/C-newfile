using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("来把你的工资填写进来看一下：");
            //string pay = Console.ReadLine();
            //int mypay = Convert.ToInt32(pay);
            //if (mypay > 5000)
            //    Console.WriteLine("恭喜你进入了穷人阶级！");////if只带这句
            //Console.WriteLine("哎哟，你还在生死线上徘徊，还要加油啊！");


            //Console.WriteLine("来把你的工资填写进来看一下：");
            //int mypay = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("再把年纪填进来看一下：");
            //int myage = Convert.ToInt32(Console.ReadLine());
            //if ((mypay>=6000&&myage>=35)||(mypay==5500&&myage>=30))
            //{
            //    Console.WriteLine("恭喜你脱离了生死线，进入了穷人阶级！");
            //}


            //Console.Write("输入用户名：");
            //string UserName = Console.ReadLine();
            //Console.Write("输入密码：");
            //string PassWord = Console.ReadLine();
            //if (UserName == "admin" && PassWord == "password")
            //{
            //    Console.WriteLine("输入正确，什么也不用打开");
            //}
            Console.WriteLine("来把你的工资填写进来看一下：");
            string pay = Console.ReadLine();
            int mypay = Convert.ToInt32(pay);
            if (mypay > 5000)
            {
                Console.WriteLine("恭喜你进入了穷人阶级！");////if只带这句
            }
            else
            {
                Console.WriteLine("哎，你还在生死线上徘徊，还要加油啊！");
            }
            Console.ReadKey(); 
        }
    }
}

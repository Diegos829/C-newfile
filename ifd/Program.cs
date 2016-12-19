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


            //Console.WriteLine("来把你的工资填进来看一下：");
            //string pay = Console.ReadLine();
            //int mypay = Convert.ToInt32(pay);
            //Console.WriteLine("再吧你老婆的工资拿来看一下");
            //string wpay = Console.ReadLine();
            //int uwpay = Convert.ToInt32(wpay);
            //if (mypay >= uwpay )
            //{
            //    Console.WriteLine("哎呀，你家还是你说了算！");////if只带这句
            //}
            //else
            //{
            //    Console.WriteLine("什么都别说了，我知道你委屈。");
            //}

            //Console.WriteLine("来随便填个数字：");
            //string pay = Console.ReadLine();
            //int mypay = Convert.ToInt32(pay);
            //Console.WriteLine("再随便写一个：");
            //string wpay = Console.ReadLine();
            //int uwpay = Convert.ToInt32(wpay);
            //if ((mypay % uwpay == 0)||(mypay + uwpay>100))
            //{
            //    Console.WriteLine("第一个数能被第二个整除，所以{0}", mypay);////if只带这句
            //}
            //else
            //{
            //    Console.WriteLine("这两个数字的和大于100，所以{0}", uwpay);
            //}

            //Console.Write("把年龄输进来，我们看看你是什么年龄段：");
            //string Age = Console.ReadLine();
            //int Uage = Convert.ToInt32(Age);
            //if (Uage > 60)
            //{
            //    Console.WriteLine("您啊，退休咯。");
            //}
            //if (Uage >= 50 && Uage < 60)
            //{
            //    Console.WriteLine("力不从心的年纪啊！");
            //}
            //if (Uage >= 30 && Uage < 50)
            //{
            //    Console.WriteLine("正当壮年！");
            //}
            //if (Uage < 30)
            //    Console.WriteLine("青春多美好，珍惜当下！");

            Console.Write("把工资输进来，我们看看你是什么人：");
            string Pay = Console.ReadLine();
            int Upay = Convert.ToInt32(Pay);
            if (Upay >= 20000)
            {
                Console.WriteLine("您跟我们玩什么啊，一边玩蛋去吧");
            }
            else if (Upay >= 10000)
            {
                Console.WriteLine("过的不错啊！");
            }
            else if (Upay >= 5000)
            {
                Console.WriteLine("恩，工薪阶层！");
            }
            else 
            { 
                Console.WriteLine("快醒醒，工头喊你搬砖了！\n好嗨森，今天又可以搬砖咯~~~");
            }
            Console.ReadKey(); 
        }
    }
}

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

            //Console.Write("把工资输进来，我们看看你是什么人：");
            //string Pay = Console.ReadLine();
            //int Upay = Convert.ToInt32(Pay);
            //if (Upay >= 20000)
            //{
            //    Console.WriteLine("您跟我们玩什么啊，一边玩蛋去吧");
            //}
            //else if (Upay >= 10000)
            //{
            //    Console.WriteLine("过的不错啊！");
            //}
            //else if (Upay >= 5000)
            //{
            //    Console.WriteLine("恩，工薪阶层！");
            //}
            //else 
            //{ 
            //    Console.WriteLine("快醒醒，工头喊你搬砖了！\n好嗨森，今天又可以搬砖咯~~~");
            //}
            //Console.ReadKey(); 

            //1
            //Console.WriteLine("来吧，直接给个密码就可以让你取钱！");
            //string Password = Console.ReadLine();
            //if (Password == "888888")
            //{
            //    Console.WriteLine("哎呀，对勒嘿，来，拿走~");
            //}
            //else
            //{
            //    Console.WriteLine("再来一次吧，直接给个密码就可以让你取钱！");
            //    Password = Console.ReadLine();
            //    if (Password == "888888")
            //    {
            //        Console.WriteLine("拿走拿走");
            //    }
            //    else
            //    {
            //        Console.WriteLine("没救了……");
            //    }
            //}
            //Console.ReadKey();

            //2
            //Console.WriteLine("您的账户名是：");
            //string UserName = Console.ReadLine();
            //Console.WriteLine("密码来一套：");
            //string Password = Console.ReadLine();

            //if (UserName == "Admin" && Password == "888888")
            //{
            //    Console.WriteLine("哎呀，对勒嘿，来，拿走~");
            //}
            //else if (UserName != "Admin")
            //{
            //    Console.WriteLine("用户名不对哟，想一哈想一哈~");
            //}
            //else 
            //{
            //    Console.WriteLine("密码不对哦，想清楚再来哈，88~");
            //}

            //Console.ReadKey();

            //3
            //Console.WriteLine("input your age:");
            ////string Age = Console.ReadLine();
            ////int Uage = Convert.ToInt32(Age);
            //int Uage = Convert.ToInt32(Console.ReadLine());
            //if (Uage >= 18)
            //{
            //    Console.WriteLine("you can look FBI WARNING!");
            //}
            //else if (Uage >= 10)
            //{
            //    Console.WriteLine("do you wont look FBI WARNING?");
            //    string Yes = Console.ReadLine();
            //    if (Yes == "yes")
            //    {
            //        Console.WriteLine("look个蛋，毛都没长齐！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("乖，听话，回家睡觉。");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("you need TianXianBaoBao~");
            //}
            //    Console.ReadKey();

            //4
            //Console.WriteLine("你等级是(A到E)：");
            //string Class = Console.ReadLine();
            //decimal salary = 5000;
            //bool flag = false;
            //if (Class == "A")
            //{
            //    salary += 500;
            //}
            //else if (Class == "B")
            //{
            //    salary += 250;
            //}
            //else if (Class == "C")
            //{
            //}
            //else if (Class == "D")
            //{
            //    salary -= 250;
            //}
            //else if (Class == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("没按提示输入");
            //    flag = true;
            //}
            //if (flag==false)
            //{ 
            //Console.WriteLine("……"+salary);
            //}
            //Console.ReadKey();

            //4-2
            //Console.WriteLine("你等级是(A到E)：");
            //string Class = Console.ReadLine();
            //decimal salary = 5000;
            //bool flag = false;
            //switch (Class)
            //{
            //    case "A":salary += 500;
            //        break;
            //    case"B":salary += 200;
            //        break;
            //    case"C":
            //        break;
            //    case "D": salary -= 200;
            //        break;
            //    case "E":salary -= 500;
            //        break;
            //    default:Console.WriteLine("必须是大写的A到E");
            //        flag = true;
            //        break;          
            //}
            //if (flag == false)
            //{
            //    Console.WriteLine("……" + salary);
            //}
            //Console.ReadKey();

            //5
            //Console.Write("input year:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.Write("input month:");
            //int month = Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.Write("leap year has 31 days");
            //        break;
            //    case 2:
            //        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            //        {
            //            Console.WriteLine("29");
            //        }
            //        else
            //        {
            //            Console.WriteLine("28");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Non leap year 30 days");
            //        break;
            //        }


            Console.Write("input your score:");
            int number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 90)
            //{
            //    Console.Write("you got A,nice job!");
            //}
            //else if (number < 90 && number >= 80)
            //{
            //    Console.Write("you got B,wow!");
            //}
            //else if (number < 80 && number >= 70)
            //{
            //    Console.Write("you got C,oh...");
            //}
            //else if (number < 70 && number >= 60)
            //{
            //    Console.Write("you got D,hmmm...");
            //}
            //else 
            //    { Console.Write("you got E,bad!");      

            //}
            switch (number / 10)
            {
                case 9:
                    Console.Write("you got A,nice job!");
                    break;
                case 8:
                    Console.Write("you got B,wow!");
                    break;
                case 7:
                    Console.Write("you got C,aha~");
                    break;
                case 6:
                    Console.Write("you got D,hmmm...");
                    break;
                default:
                    Console.Write("you got E,oh my god...");
                    break;
            }
            Console.ReadKey();
        }
    }
}

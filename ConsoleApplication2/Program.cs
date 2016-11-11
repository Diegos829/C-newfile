using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "猪大肠", 
                phna = "弱鸡鸭",
                phtype = "X78", 
                price = "888";      
            double weigh = 10.5;                 
            char sex = '男';
            int age = 28;
            string ph = "13800138000";      
            Console.WriteLine("此人叫做{0}，{1}的，{2}岁，帅的狗屎一样，电话号码是{3}。",name,sex,age,ph);
            Console.WriteLine("电话型号是{0}{1}，这个手机卓越不凡，仅重{2}公斤，只卖{3}元。请到淘东网站，搜《猪大肠》，欲购从速。",phna,phtype,weigh,price);
            Console.ReadKey();
        }
    }
}

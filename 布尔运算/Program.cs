using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 布尔运算和自加减
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = (int)99.9, Num2 = 100, Num3 = 99;
            //bool IsRight = Num1 < Num2;
            //bool IsRight2 = Num1 > Num3;
            bool IsRight=Num1!=Num2;
            Console.WriteLine(IsRight);
            Console.ReadKey();
            //Console.WriteLine(IsRight2);

            //int Num1 = 1, Num2 = 9, Num3 = Num1++, Num4 = Num2--,Num5=++Num1,Num6=--Num2;
            //Console.WriteLine(Num3);
            //Console.WriteLine(Num4);
            //Console.WriteLine(Num1 + Num3);
            //Console.WriteLine(Num2 - Num4);
            //Console.WriteLine(Num5);
            //Console.WriteLine(Num6);
            //Console.WriteLine(Num3 + Num5);
            //Console.WriteLine(Num4 - Num6);

            Console.ReadKey();
        }
    }
}

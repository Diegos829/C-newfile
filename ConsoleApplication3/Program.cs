using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3,
                num2 = 9,
                temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1={0},num2={1}。",num1,num2);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("input your math score:");
                int Mscore = Convert.ToInt32(Console.ReadLine());
                Console.Write("input your chinese score:");
                int Cscore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("totle{0}",Mscore + Cscore);
            }
            catch {
                Console.WriteLine("error!check your input number!");
            }
            Console.ReadKey();

        }
    }
}

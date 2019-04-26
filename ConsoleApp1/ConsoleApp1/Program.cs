using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tochnost = 0.000001;
            Console.WriteLine(Pi(tochnost));
            Console.WriteLine(Math.PI);
            Console.ReadKey();
        }

        static double Pi(double tochnost)
        {
            double res = 0.0;
            double i = 1.0;
            double x = 4.0;
            int k = 1;
            while (Math.Abs(x) > tochnost)
            {
                res += x;
                k *= -1;
                i += 2;
                x = k * 4 / i;
            }
            return res;
        }
    }
}

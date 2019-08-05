using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=Sum(20,40);
            Console.WriteLine($"The Sum() with two arguments, result is : {result}");

            int result3 = Sum(20, 40, 80);
            Console.WriteLine($"The Sum() with three arguments, result is : {result3}");

            double dblresult = Sum(20.5, 40.6);
            Console.WriteLine($"The Sum() that takes double result in : {dblresult}");
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            //Console.WriteLine($"The sum of {first} and {second} is : {sum}");
            return sum;
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(2,3).ToString());
            Console.ReadLine();
        }

        public static  int add(int a,int b)
        {
            return a + b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program


    {

        static int divide(int a, int b)
        {
            int c = a / b;
            return (c);
        }
       static int plus(int a, int b)
        {
            int c = a + b;
            return (c);
        }
        static int minus(int a, int b)
        {
            int c = a - b;
            return (c);
        }
        static int mult (int a, int b )
        {
            int c = a * b;

            return (c);
        }
        static void Main(string[] args)
        {
            int c = minus(mult(plus(divide(1, 2), 3),4),5); 

        }
    }
}

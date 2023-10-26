using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    class method
    {          
        void method1()
        {
            Console.WriteLine("method one");
        }
        static void method2()
        {
            Console.WriteLine("static method is called");
            method obj = new method();
            obj.method1();
        }
        int method3(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("main method");
            method obj = new method();
            obj.method3(5, 6);
            Console.WriteLine(" sum of int method "+obj.method3(5, 6));
            obj.method1();
            method2();
        }
    }
}

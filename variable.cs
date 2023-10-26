using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
   class variable
    {
        int a = 10;//instant variable
        static int b = 20;//static variable 
        int c;//by defualt instant variable value is 0(zero)
        void methhod1()
        {
            b++;
            variable obj = new variable();
            int y = obj.a;
            obj.a = a++;
            y++;
        }
        static void Main(String[]args)
        {
            variable obj = new variable();
            int x = obj.a;
            Console.WriteLine("instant variable" + x);
            obj.methhod1();
            Console.WriteLine("static variable "+b);
            int y = obj.c;
            Console.WriteLine(" c variable " + y);
            const string n = " raju";//constant variable
            Console.WriteLine(" constant string " + n);
            Boolean local = false;//local variable
            Console.WriteLine("local boolean value " + local);


        }
    }
}

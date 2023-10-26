using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    class String
    {
        string method(string value)
        {
            string var1 = value.Substring(2,4);
            //string con = value.c;
            return var1;
        }
        static void Main(string[]args)
        {
            //group of character together is called string
            string var = " ravi charan";
            //var is a reference because it store adress of r a v i
            Console.WriteLine(var);
            Console.WriteLine(var.Length);
           string name =  var.Replace(var, "shubbu");
            Console.WriteLine(name);
            Console.WriteLine(" index "+var.IndexOf('a'));
            Console.WriteLine(var.StartsWith("ravi"));
            Console.WriteLine(var.EndsWith("ravi"));
            Console.WriteLine(var.Equals(name));
            String obj = new String();
           // obj.method(var);
            Console.WriteLine(" the string is "+obj.method(var));
        }
    }
}

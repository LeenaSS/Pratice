using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisum
{
    public class Parentclass
    {
        public Parentclass()
        {
            Console.WriteLine(" parent class calles");
        }
        public Parentclass(string name) 
        {
            Console.WriteLine(name);
        }
    }
    public class Childclass : Parentclass
    {
        public Childclass(): base(" Name is raju")
        {
            Console.WriteLine(" child class called");
        }
    }
    public class Con
    {
        static void Main(string[] args)
        {
            Childclass cobj = new Childclass();

        }
    }
}

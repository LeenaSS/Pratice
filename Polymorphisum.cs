using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisum
{
    // polymorphisum enables us  to invoke derived class
    // methods throungh  a base class reference variable using at run time 
    public class employee
    {
        public int id = 2;
        public string name = "shilpa";
        public virtual void details()
        {
            Console.WriteLine("Name : "+name+" Id :"+id);
        }
    }
    public class firstemployee: employee
    {

        public override void details() 
        {
            Console.WriteLine("Name : " + name + " Id :" + id+" fulltime employee");
        }
    }
    public class partemployee:employee
    {
        public override void details()
        {
            Console.WriteLine("Name : " + name + " Id :" + id+" part time employee");
        }
    }
    public  class program
    {
        static void Main(string[] args)
        {
            employee[] employee = new employee[3];
            employee[0] = new employee();
            employee[1] = new firstemployee();
            employee[2] = new partemployee();
            foreach(var item in employee) 
            {
                item.details();
            }

        }
    }
}

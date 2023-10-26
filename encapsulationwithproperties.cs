using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso.Encapsulationwithproperties
{
    public class properties
    {
        private int num;
        private string name;
        private string des;
        private DateTime createdAt;
        public int num1
        {
            get
            { return num;
            } set { num = value; }
        }
            public string Name
             {
            get
            {  return name; }
            set
            { name = value; }
        }
            public string Des
        {
            get
            { return des; }
            set
            { des = value; }

        }
        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
        }
            public properties()
        {
            this.createdAt = DateTime.Now;
        }

        }
    public class program
    {
        static void Main()
        {
            properties p = new properties();
            p.Name = "test";
            p.Des = "orange";
            p.num1 = 22;
            Console.WriteLine($" name is {p.Name} age {p.num1} desg {p.Des}");
        }
    }
}

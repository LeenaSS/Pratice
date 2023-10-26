using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    public  class encapsulation
    {
        private int num;
        private string name;
        private string des;
        public void SetName(string  pname)
        {
            this.name = pname;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetNum(int pnum)
        {
            this.num = pnum;
        }
        public int GetNum()
        {
            return this.num;
        }
        public void SetDes(string pdes)
        {
            this.des = pdes;
        }
        public string GetDes()
        {
            return this.des;
        }
            public  void display()
        {
            Console.WriteLine($" details are name: {name}  number :{num} desgination :{des} ");
        }
    }
    

}

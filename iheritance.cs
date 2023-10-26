using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{ 
    public class iheritance
    {
        public int num ;
        public string name;
        public void  print()
        {
            Console.WriteLine($" Name: {name} batchno: {num}");
        }
    }
    public class fulltime: iheritance//,A multiple inheritance cannot be supported
    {
        public int year;    
    }
    public class parttime: iheritance
    {
        
        public float month;
       
    }
    /*public class A
    {

    }*/
    public class supportwork: fulltime//multi level inhetitance
    {
        public int work;

    }
    public class programinhetence
    {
        static void Main(string[] args)
        {
            fulltime ft = new fulltime();
            Console.WriteLine(" enter batch no");
            ft.num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter name");
            ft.name = Console.ReadLine();
            Console.WriteLine(" enter  salary");
            ft.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" first salary  year: " + ft.year);
            ft.print();
            //supportwork sw = new supportwork();
            //Console.WriteLine(" enter the work");
           // sw.work=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" the work is :"+sw.work);

        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 5, 76 };
            Array.Reverse(a);
            Console.WriteLine("reverse order : ");
            for(int i=0; i<3;i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Array.Sort(a);
            Console.WriteLine("sorting order: ");
            foreach(int  i in a)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}

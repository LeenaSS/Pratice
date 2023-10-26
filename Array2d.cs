using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    class Array2d
    {
        static void Main(string[] args)
        {
            int[,] a;
            Console.WriteLine("enter rows and columns you want");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            a = new int[r, c];
            Console.WriteLine("enter elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the given list");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine(" " + a[i,j]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    class Accessmodifier
    {
        private int a = 10;
        void method()
        {
            Accessmodifier o = new Accessmodifier();
            Console.WriteLine(o.a);
        }
        
        static void Main(string[] args)
        {
            //private: with in the class
            // public :any where
            //protected :with in class and derived class
            //internal :with in namespace 
            //protected :internal combination of protected and internal
            //private protected: combination of private and protected
            Accessmodifier obj = new Accessmodifier();
            obj.method();
             
        }
    }
}

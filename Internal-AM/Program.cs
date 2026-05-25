using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_AM
{
    class myclaas
    {
        internal int a = 10;
        public void myMethod()
        {
            Console.WriteLine("value of a under mymethod is " + a);
        }
    }
    class newclass
    {
        public void newMethod()
        {
            myclaas obj = new myclaas();
            Console.WriteLine("value of a under newmethod is " + obj.a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclaas obj1 = new myclaas();
            obj1.myMethod();
            newclass obj2 = new newclass();
            obj2.newMethod();
        }
    }
}

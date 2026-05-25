using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @private
{
    class jammes
    {
        int sid=1;

        public void DoSomething()
        {
            Console.WriteLine("Doing something in PrivateClass."+sid);
        }
    }
    internal class Program
    {
        static void Main(string [] args)
        {
            jammes jj= new jammes();
            jj.DoSomething();
        }
    }
}

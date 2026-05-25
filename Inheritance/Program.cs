using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class branch
    {
        int bid;
        string bname;
        string baddress;
        public branch(int bid,string bname, string baddress)
        {
            this.bid = bid;
            this.bname = bname;
            this.baddress = baddress;
        }
        public void bdisplay()
        {
            Console.WriteLine("Branch id is " + bid);
            Console.WriteLine("Branch name is " + bname);
            Console.WriteLine("Branch address is " + baddress);
        }
    }
    class student : branch
    {
        int sid;
        string sname;
        string scollege;

        public student(int sid, string sname, string scollege):base (111,"bbb","Amerapet")
        {
            this.sid = sid;
            this.sname = sname;
            this.scollege = scollege;
        }
        public void sdisplay()
        {
            Console.WriteLine("Student id is " + sid);
            Console.WriteLine("Student name is " + sname);
            Console.WriteLine("Student college is " + scollege);
            base.bdisplay();
        }
    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(1, "John", "IIIT");
            s.sdisplay();
        }
    }
}

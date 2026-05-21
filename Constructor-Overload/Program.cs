using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overload
{
    class Student
    {
        int sid;
        string sname;
        string college;

        public Student()
        {
            sid = 0;
            sname = "Unknown";
            college = "Unknown";
        }

        public Student(int sid, string sname, string college)
        {
            this.sid = sid;
            this.sname = sname;
            this.college = college;
        }
        public Student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
            this.college = "Not Provided";
        }

        public void display()
        {
            Console.WriteLine("Student id: " + sid);
            Console.WriteLine("Student name: " + sname);
            Console.WriteLine("College: " + college);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu .display();
            Student stu1 = new Student(101, "John", "ABC");
            stu.display();
            Student stu2 = new Student(102, "Jane");
            stu2.display();
        }
    }
}

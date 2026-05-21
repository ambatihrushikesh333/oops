using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student

{
    class Student
    {
        int sid;
        string sname;
        public Student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        public void display()
        {
            Console.WriteLine("Student id: " + sid);
            Console.WriteLine("Student name: " + sname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of studnts:");
            int n = int.Parse(Console.ReadLine());
            Student[] s = new Student[n];
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("enter student id:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter student name:");
                    string name = Console.ReadLine();
                    s[i] = new Student(id, name);
                }
                Console.WriteLine("student details:");
                for (int i = 0; i < n; i++)
                {
                    s[i].display();
                }
            }
        }
    }
}
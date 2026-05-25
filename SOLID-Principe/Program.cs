using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principe
{
   class Reports 
    {
      public void GetReports()
        {
            Console.WriteLine("reports content");
        }


        public void PrintReports()
        {
            Console.WriteLine("Prints printed");
        }
        public void BillReports()
        {
            Console.WriteLine("bill genreted");
        }

    }
   class getreports
    {
        public void GetReports()
        {
            Console.WriteLine("reprts content");
        }
    }
    class PrintReports
    {
        public void BillReports()
        {
            Console.WriteLine("print reports");
        }
        public void MSSWord()
        {
            Console.WriteLine("MS Word docement");
        }
    }
    class BillReport
    {
        public void BillReports()
        {
            Console.WriteLine("bill generted");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Reports r = new Reports();
            r.GetReports();
            r.PrintReports();
            r.BillReports();
        }
    }
}

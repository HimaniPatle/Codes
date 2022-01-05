using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Sat
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails Stu1DetailsObj = new StudentDetails(101, "Himani", "c#");
            StudentDetails Stu2DetailsObj = new StudentDetails(102, "Kajal", "ASP.Net");

            Stu1DetailsObj.Payment(1000);
            Stu2DetailsObj.Payment(500);

            Stu1DetailsObj.Print();
            Console.WriteLine();
            Stu2DetailsObj.Print();

            Console.ReadKey();

        }
    }
}

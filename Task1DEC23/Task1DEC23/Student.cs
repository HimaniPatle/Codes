using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DEC23
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine("Roll no :" +rollno);
            Console.WriteLine("Name :" +name);
            Console.WriteLine("Course :" +course);
            Console.WriteLine("Fee paid : " +feepaid);
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                return course == "c#" ? 2000 : 3000;
            }
        }
    }
}

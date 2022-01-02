using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec6
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person APerson = new Person();
            APerson.Greet();

            Student AStudent = new Student();
            AStudent.SetAge(21);
            AStudent.Greet();
            AStudent.ShowAge();
            AStudent.GoToClasses();

            Teacher ATeacher = new Teacher();
            ATeacher.SetAge(30);
            ATeacher.Greet();
            ATeacher.Explain();

            Console.ReadKey();
        }
    }
}

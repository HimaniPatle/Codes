using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec6
{
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My Age is: {0} years old", age);
        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
    }
}

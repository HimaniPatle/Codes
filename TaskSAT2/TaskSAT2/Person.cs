using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSAT2
{
    class Person
    {
        protected string FirstName;
        protected string LastName;
        protected int ID;
        
        public Person(string FirstName, string LastName, int ID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ID = ID;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name: " + LastName + "," + FirstName + "\nID: " + ID);
        }
    }
}

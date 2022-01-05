using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList Details = new ArrayList();

            int TotalPer = 3;
            for(int i=0; i< TotalPer; i++)
            {
                string Name = Console.ReadLine();
                int Age = int.Parse(Console.ReadLine());

                Details.Add(new Person() { Name = Name, Age = Age });
              
            }
            foreach(Person p in Details)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
        }
    }
}

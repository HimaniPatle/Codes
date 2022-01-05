using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOfOject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack PerDetails = new Stack();

            int count = 3;

            for(int i = 0; i < count; i++)
            {
                string Name = Console.ReadLine();
                int Age = int.Parse(Console.ReadLine());

                PerDetails.Push(new Person() { Name = Name, Age = Age });
            }
            for(int i = 0; i < count; i++)
            {
                Person p = (Person)PerDetails.Pop();
                Console.WriteLine(p.ToString());
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}

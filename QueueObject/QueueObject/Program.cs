using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue QueObj = new Queue();
            int count = 3;

            for (int i = 0; i < count; i++)
            {
                string Name = Console.ReadLine();
                int Age = int.Parse(Console.ReadLine());

                QueObj.Enqueue(new PerDetails() { Name = Name, Age = Age });
            }
            for (int i = 0; i < count; i++)
            {
                PerDetails p = (PerDetails)QueObj.Dequeue();
                Console.WriteLine(p.ToString());
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}

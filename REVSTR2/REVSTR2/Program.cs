using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVSTR2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            string revStr = string.Join(" ", str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"{revStr}");
           
            Console.ReadKey();
        }
    }
}

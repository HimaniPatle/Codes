using System;
using System.Collections.Generic;
using System.Linq;

namespace NoFromRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 40, 43, 54, 12, 34, 56, 76, 99, 23, 22, 231, 444 };
            var RequiredNum = Numbers.Where(a => a > 30).Where(a => a < 100);
            foreach (var num in RequiredNum)
            {
                Console.WriteLine($"{num} ");
                Console.ReadKey();
            }
        }
    }
}

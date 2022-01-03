using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevEachWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string str = Console.ReadLine();
            string[] a = str.Split(' ');
            int m = a.Length - 1;
            x = m;
            for (int i = m; x >= 0; m--)
            {
                Console.Write(a[x] + "" + ' ');
                --x;
            }
            Console.ReadKey();
        }
    }
}

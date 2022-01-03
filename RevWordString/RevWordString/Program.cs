using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevWordString
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            string s = Console.ReadLine();

            string[] a = s.Split(' ');

            int k = a.Length - 1;

            temp = k;

            for (int i = k; temp >= 0; k--)

            {

                Console.Write(a[temp] + "" + ' ');

                --temp;

            }

            Console.ReadKey();
        }
    }
}

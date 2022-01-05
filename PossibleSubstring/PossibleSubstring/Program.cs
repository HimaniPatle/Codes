using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string iString = Console.ReadLine();
            Console.Write("All Substrings for given string are : ");
            for(int i=0; i<iString.Length;i++)
            {
                StringBuilder subString = new StringBuilder(iString.Length - i);
                for(int j=i;j<iString.Length;++j)
                {
                    subString.Append(iString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadLine();
            Console.WriteLine("-----------");
        }
    }
}

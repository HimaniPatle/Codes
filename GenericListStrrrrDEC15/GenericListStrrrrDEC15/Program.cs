using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListStrrrrDEC15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfInt = Cal(new List<string>(new string[] { "abc", "cdaef", "jc", "php"}));

            foreach (var list in ListOfInt)
            {
                Console.WriteLine(list.ToString() + " ");
                Console.ReadKey();

            }
        }
        public static List<string> Cal(List<string> Lstr)
        {

            return Lstr.Select(z => z.Replace("a", "")).ToList();
        }
    }
}
   


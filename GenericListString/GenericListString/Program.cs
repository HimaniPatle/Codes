using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfInt = Cal(new List<string>(new string[] { "1", "2", "3", "4", "5" }));

            foreach (var list in ListOfInt)
            {
                Console.WriteLine(list.ToString() + " ");
                Console.ReadKey();

            }
        }
        public static List<string> Cal(List<string> strnum)
        {
            IEnumerable<string> str = strnum.Select(a => a = a + a + a + a);
            return str.ToList();
        }
    }
}

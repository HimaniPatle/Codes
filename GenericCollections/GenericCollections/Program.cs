using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListOfInt = Cal(new List<int>(new int[] { 1, 2, 3, 4, 5 }));
            /*ListOfInt.Add(1);
            ListOfInt.Add(2);
            ListOfInt.Add(3);
            ListOfInt.Add(4);
            ListOfInt.Add(5);*/

            foreach (var list in ListOfInt)
            {
                Console.WriteLine(list.ToString()+ " ");
                Console.ReadKey();

            }
        }
        public static List<int> Cal(List<int> num)
        {
            IEnumerable<int> n = num.Select(a => 5 * (a + 2));
            return n.ToList();
            
        }
    }
}

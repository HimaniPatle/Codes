using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHands_on
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDetails c = new CarDetails();
            Console.WriteLine(c.SuccessRate(10));
            Console.WriteLine(c.ProductionRatePerHr(6));
            Console.WriteLine(c.WorkingItemsPerMin(6));
            Console.ReadLine();
        }
    }
}

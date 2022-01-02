using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment9DEC
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkDetails NetworkObj = new NetworkDetails();
            NetworkObj.GetNetworkDetails();
            Console.ReadKey();
        }
    }
}

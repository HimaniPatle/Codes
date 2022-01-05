using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNetworkMonDec13
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkDetails NetObj = new NetworkDetails();
            NetObj.GetNetworkDetails();

            Console.ReadKey();
        }
    }
}

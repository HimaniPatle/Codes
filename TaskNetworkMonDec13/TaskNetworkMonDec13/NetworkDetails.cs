using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskNetworkMonDec13
{
    class NetworkDetails
    {
        public void GetNetworkDetails()
        {
            FileStream FileObj = new FileStream("E:\\csharp\\MonNetwork.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(FileObj);


            string[] ID = new string[12];
            string[] Source = new string[12];
            string[] Destination = new string[12];
            string[] Date = new string[12];
            string[] Status = new string[12];
            string[] Network = new string[12];

            int values = 0;
            int a = 0;
            int b = 6;
            int c = 12;

            while (sr.Peek() > 0)
            {
                string readDetails = sr.ReadLine();
                string[] strings = readDetails.Split(':');
                if (strings.Length > 1)
                {
                    ID[values] = strings[0];
                    Source[values] = strings[1];
                    Destination[values] = strings[1];
                    Date[values] = strings[1];
                    Status[values] = strings[1];
                    Network[values] = strings[1];
                }
            }
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(ID[i] + "   ");
                Console.WriteLine(Source[i] + "   ");
                Console.WriteLine(Destination[i] + "   ");
                Console.WriteLine(Date[i] + "   ");
                Console.WriteLine(Status[i] + "   ");
                //Console.WriteLine(Source[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            /*while (c > 0)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(Network[i] + "   ");
                }
                a = a + 6;
                b = b + 6;
                Console.WriteLine();
                Console.WriteLine();
                c = c - 1;
            }*/
            sr.Close();
            FileObj.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment9DEC
{
    class NetworkDetails
    {
        public void GetNetworkDetails()
        {
            FileStream fileObj = new FileStream("E:\\csharp\\Networkss.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileObj);
            string[] str1 = new string[78];
            string[] str2 = new string[78];
            int values = 0;
            int a = 0;
            int b = 6;
            int c = 12;
            while (sr.Peek() > 0)
            {
                string readNetwork = sr.ReadLine();
                string[] strings = readNetwork.Split(',');
                if (strings.Length > 1)
                {
                    str1[values] = strings[0];
                    str2[values] = strings[1];
                    values++;
                }
            }
            for (int i = a; i < b;i++)
            {
                Console.Write(str1[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            while(c>0)
            {
                for(int i = a; i < b; i++)
                {
                    Console.Write(str2[i] + "   ");
                }
                a = a + 6;
                b = b + 6;
                Console.WriteLine();
                Console.WriteLine();
                c = c - 1;
            }
            sr.Close();
            fileObj.Close();
        }
    }
}

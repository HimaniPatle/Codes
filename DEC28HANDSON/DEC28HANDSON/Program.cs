using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEC28HANDSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (s.Length > 0)
            {
                Console.Write(s[0]+ "-");
                int call = 0;
                for(int j =0; j <s.Length; j++)
                {
                    if(s[0]==s[j])
                    {
                        call++;
                    }
                }
                Console.WriteLine(call);
                s = s.Replace(s[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}

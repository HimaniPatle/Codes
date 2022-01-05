using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSAT2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the FirstName : ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter the LastName : ");
            string LastName = Console.ReadLine();
            Console.Write("Enter ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the Num of Scores : ");
            int NumScores = int.Parse(Console.ReadLine());
            int[] TestScores = new int[NumScores];

            for(int i = 0; i < NumScores; i++)
            {
                Console.Write("Enter the TestScores {0}:", (i + 1));
                TestScores[i] = int.Parse(Console.ReadLine());
            }
            Student StuObj = new Student(FirstName, LastName, ID, TestScores);
            StuObj.PrintPerson();
            Console.WriteLine("Grade : " + StuObj.Calculate());

            Console.ReadLine();
        }
    }
}

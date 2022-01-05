using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSAT2
{
    class Student : Person
    {
        private int[] TestScores;
        public Student(string FirstName, string LastName, int ID, int[] TestScores)

          :base(FirstName,LastName,ID)
        {
            this.TestScores= TestScores;
        }
        public char Calculate()
        {
            float Average = 0;
            float Sum = 0;
            char Grade = ' ';

            for ( int i=0, length=this.TestScores.Length; i<length; i++)
            {
                Sum += this.TestScores[i];
            }
            if(TestScores.Length !=0)
                Average = Sum/(float)TestScores.Length;
            if (Average >= 90 && Average <= 100)
            {
                Grade = 'O';
            }
            else if (Average >= 80 && Average < 90)
            {
                Grade = 'E';
            }
            else if (Average>= 70 && Average < 80)
            {
                Grade = 'A';
            }
            else if (Average >= 55 && Average < 70 )
            {
                Grade = 'P';
            }
            else if (Average >= 40 && Average < 55)
            {
                Grade = 'D';
            }
            else if(Average < 40)
            {
                Grade = 'T';
            }
            return Grade;

        }
       
    }
}

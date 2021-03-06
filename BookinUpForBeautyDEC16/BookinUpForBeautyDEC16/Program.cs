using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace BookinUpForBeautyDEC16
{
    class Program
    {
            static void Main()
        {
            #region Schedule
            ApointmentTest.Schedule();
            Console.WriteLine("DateTime:");
            string line = Console.ReadLine();
            string[] val = line.Split('/', ' ', ':');
            Console.Write("new DateTime:" + val[2] + "," + val[0] + "," + val[1] + "," + val[3] + "," + val[4] + "," + val[5]);
            string NewDateTime = Console.ReadLine();

            Console.ReadKey();
            #endregion Schedule

            #region HasPassed
            ApointmentTest.HasPassed();
            string DateTime = "1999,12,31,9,0,0";

            if (NewDateTime != DateTime)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
            #endregion HasPassed

            #region IsAfternoonAppointment
            ApointmentTest.IsAfternoonAppointment();
            string DateTime2 = "2019,03,29,15,0,0";

            if (NewDateTime != DateTime2)
            {
                if (Convert.ToDateTime("13:45") >= Convert.ToDateTime("12:00") && Convert.ToDateTime("13:45") < Convert.ToDateTime("18:00"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();

            #endregion IsAfternoonAppointment

            #region Description
            ApointmentTest.Description();

            Console.WriteLine("Enter Appointment Date and Time:");

            string NewDateTime2 = Console.ReadLine();
            string[] item = NewDateTime2.Split(',');


            Console.Write("You have an appointment on:");
            Console.Write(item[1] + "/" + item[2] + "/" + item[0] + " " + item[3] + ":" + item[4] + ":" + item[5] + " " + "PM");

            Console.WriteLine();
            Console.ReadKey();
            #endregion Description

            #region AnniversaryDate
            ApointmentTest.AnniversaryDate();

            string str = "09/15/2019 0:0:0";
            string[] value = str.Split('/', ' ', ':');
            Console.WriteLine("new DateTime:" + value[2] + "," + value[0] + "," + value[1] + " ," + value[3] + "," + value[4] + "," + value[5]);


            Console.ReadKey();
            #endregion AnniversaryDate


        }

    }
}
    
            


            


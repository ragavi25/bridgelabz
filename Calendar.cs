//--------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name=" R Ragavi>
// -------
using System;

namespace Datastructure
{
    /// <summary>
    /// PURPOSE :
    /// </summary>
    class Calendar
    {
        public void Showcalendar()
        {
            //// Given the month, day, and year, return which day
            ////of the week it falls on according to the Gregorian calendar.
            ////For month, use 1 for January, 2 for February, and so forth.

            //// Returns 0 for Sunday, 1 for Monday, and so forth.
            Console.Write("Enter the month");
            int month = Utility.Usermonth();
            Console.Write("Enter the day");
            int day = Utility.Userday();
            Console.Write("Enter the year");
            int year = Utility.Useryear();
            //// leave empty so that months[1] = "January"
            String[] months =  { "0","January" ,"Frebraury","March","April","May","June","July",
				"August","September","october","november","December"};

            int[] days = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            if (month == 2 && Isleapyear(year))
                days[month] = 29;

            Console.WriteLine("      "+months[month]+"  "+year);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat ");
            int d = Days1(month, day, year);
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine("    ");
            }

            for (int i = 1; i <= days[month]; i++)
            {
                
                    Console.Write(i + "  ");
                    if ((i + d) % 7 == 0 || i == days[month])
                        Console.WriteLine();
                
            }  
                
            

               
        }
        public static int Days1(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;

            return d;
        }
        /// <summary>
        /// purpose:  return true if the given year is a leap year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool Isleapyear(double year)
        {
            if((year % 4==0) &&(year % 100 !=0))
            {
                return true;
            }
            if(year % 400 ==0)
            {
                return true;
            }
            return false;
        }
    }
}

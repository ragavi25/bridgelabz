using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Leapyear
    {
        public void leapyear()
        {
            int year;
            Console.WriteLine("Enter a year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                if (year % 100 != 0)
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine(year + "is a not Leapyear");
                    }
                }
            }
            else { 
            Console.WriteLine(year + "is a Leapyear");
        }
        }
    }
}

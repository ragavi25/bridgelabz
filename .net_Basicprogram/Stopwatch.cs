
using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{

    class Stopwatch
    {
        public void stopwatch()
        {
            int i;

            int[] start = new int[3];

            Console.WriteLine("enter the starting time: ");


            for (i = 0; i < 3; i++)
            {
                int n = Utility.Userinteger();

                start[i] = start[i] + n;

            }
            Console.WriteLine("enter the end time: ");

            int[] end = new int[3];

            for (i = 0; i < 3; i++)
            {
                int n = Utility.Userinteger();

                end[i] = end[i] + n;

            }
            Console.WriteLine("the start time is: " + start[0] + "HH:" + start[1] + "MM:" + start[2] + "SS");

            Console.WriteLine("the stop time is: " + end[0] + "HH:" + end[1] + "MM:" + end[2] + "SS");


            String s = Stopwatch1(start, end);

            Console.WriteLine("the elapsed time is: " + s);

        }
    
        public static  String Stopwatch1(int[] start, int[] end)

        {
            // int i;

            String str = " ";

            double n1 = (start[0] * 3600) + (start[1] * 60) + start[2];

            double n2 = (end[0] * 3600) + (end[1] * 60) + end[2];

            double t = Math.Abs(n1 - n2);

            int hours = (int)Math.Round(t / 3600);
            int min = (int)Math.Round((t - (hours * 3600)) / 60);
            double sec = t - (hours * 3600) - (min * 60);

            str = hours + "HH:" + min + "MM:" + sec + "SS";

            return str;
        }





    }
}

        


       
       
  
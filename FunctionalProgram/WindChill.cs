using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programs
{
    class WindChill
    {
        public void WindChill1()
        {
            double t, v, w;
            Console.WriteLine("Enter a temperature:");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a wind speed:");
            v = Convert.ToDouble(Console.ReadLine());
             w =35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("Temperature = " + t);
          Console.WriteLine("Wind speed  = " + v);
            Console.WriteLine("Wind chill  = " + w); 

        }
    }
}

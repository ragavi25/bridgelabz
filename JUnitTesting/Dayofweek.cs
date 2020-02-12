using System;
using System.Collections.Generic;
using System.Text;

namespace Junit_testing
{
    class Dayofweek
    {
        public    void dayofweek()
        {
           
             double m = Utility.UserInputs();
            m = Convert.ToInt64(Console.ReadLine());
                      double d = Utility.Userdate();
           d= Convert.ToInt64(Console.ReadLine());

           double y = Utility.Useryear();
           y= Convert.ToInt64(Console.ReadLine());
            double y0 = y - (14 - m) / 12;
            double x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            double m0 = m + 12 * ((14 - m) / 12) - 2;
            double d0 = (d + x + (31 * m0) / 12) % 7;

            Console.WriteLine(d0);
        }
    }
}

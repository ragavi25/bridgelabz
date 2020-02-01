using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programs
{
    class distance
    {
        public void distance1()
        {
            int X, Y;
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());
            double distance2 = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

            Console.WriteLine("Distance from (0, 0) to (" + X + ", " + Y + ") is " + distance2);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Junit_testing
{
    class sqrtn
    {
        public void Newtons()
        {

           
           int [] c1= { 1, 2, 3, -2, 0, -0, -1 };
            

            for (int i = 0; i < c1.Length; i++)
            {
                if (c1[i] < 0)
                {
                    Console.WriteLine("NaN");
                }
                else
                {
                    double EPSILON = 1E-15;
                    double t = c1[i];
                    while (Math.Abs(t - c1[i] / t) > EPSILON * t)
                        t = (c1[i] / t + t) / 2.0;
                    Console.WriteLine(t);
                }
            }
        }

     
        }
    }



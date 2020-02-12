using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programs
{
    class Quadratic
    {
        public void Quadratic1()
        {
            double a, b, c,root1,root2;
            Console.WriteLine("Enter a value");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b value");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c value");
            c = Convert.ToDouble(Console.ReadLine());
            
          double  delta=b*b-4 *(a * c);
            if (delta > 0)
            {
                 root1 = -b + Math.Sqrt(delta) / (2.0 * a);
                 root2 = -b - Math.Sqrt(delta) / (2.0 * a);
                Console.WriteLine("condition for real and different roots");
                Console.WriteLine("The first root:" + root1);
                Console.WriteLine("The second root:" + root2);
            }
            else if(delta==0)
                {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("Condition for real and equal roots:"+root1);
              
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("real:"+realPart);
                Console.WriteLine("imaginary:"+imaginaryPart);

                 
            }



        }

       
    }
}

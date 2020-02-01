using System;
using System.Collections.Generic;
using System.Text;

namespace Junit_testing
{
    class Binary
    {
        public   void binary2()
        {
            
            int number = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            while (power <= number / 2)
            {
                power *= 2;
            }
            while (power > 0)
            {

                if (number < power)
                {
                    Console.Write(0);
                    
                }
                else
                {
                    Console.Write(1);
                    number -= power;
                }
                power /= 2;
            }
            Console.WriteLine("Enter your choice:\n 1:swapp nibble\n 2:Find the resultant number is the number is a power of 2:");
            int opp = Convert.ToInt32(Console.ReadLine());
            switch(opp)
            {
                case 1:
                  int  number1 = Convert.ToInt32(Console.ReadLine());
                   int C=(number1 & 0x0F) << 4 | (number1 & 0xF0) >> 4;
                    Console.WriteLine(C);

                    Console.WriteLine(Math.Pow(C,2));
                    break;
            }
        }
    }
}

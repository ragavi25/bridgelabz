using System;
using System.Collections.Generic;
using System.Text;

namespace Junit_testing
{
    class temperaturConversion
    {
        public void temperaturConversion1()
        {
            double f, c;
            c= Utility.UserCelsius();
            f = Utility.UserFahrenheit();
            Console.WriteLine("enter tour conversion :\n 1:C TO F \n 2:F TO C");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("enter the celsius temperature");
                    f = (c * 9 / 5) + 32;
                    Console.Write("Celsius to Fahrenheit:"+f);
                    break;
                case 2:
                    Console.WriteLine("enter the fahrenheit temperature");
                    c = (f-32)*5/9 ;
                    Console.Write(" Fahrenheit to Celsius:" + c);
                    break;
                default:
            Console.Write("plz enter invalid number");
                    break;

            }
        }
    }
}

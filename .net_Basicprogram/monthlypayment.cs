using System;
using System.Collections.Generic;
using System.Text;

namespace Junit_testing
{
    class monthlypayment
    {
        public void monthlypayment1()
        {
            Console.WriteLine("enter principal:");
            double principal = Utility.Userprincipal();
            Console.WriteLine("enter a year:");
            double year = Utility.Useryear();
            Console.WriteLine("enter a rate:");
            double rate = Utility.Userrate();
            double n;

            rate = rate / (12 * 100);
            n = 12 * year;
            double c = 1 - Math.Pow((1 + rate), -n);
            double payment=principal*rate/c;
            double interest = payment * n - principal;
            Console.WriteLine("monthly payment:"+payment);
            Console.WriteLine("interest:" + interest);



        }
    }
}

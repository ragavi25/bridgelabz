using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Poweroftwo
    {
        public void poweroftwo()
        {
            int power_two = 1;
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(i+" "+power_two);
                power_two=2 * power_two;

            }


        }
    }
}

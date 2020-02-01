using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Harmonicnum
    {
        public  void harmoincnumber()
        {
            float harmoinc = 1;
            Console.WriteLine("Enter nth number");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=N;i++)
            {
                Console.WriteLine(i);
                    harmoinc += (float)1/i;
                Console.WriteLine(harmoinc);
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Flipcoin
    {
        public void flip()
        {
             
            double  head = 0.0;
             double tail = 0.0;
            Console.WriteLine("Enter amount of time:");
          int  toss = Convert.ToInt32(Console.ReadLine());
            //Random coin = new Random();
            // int random = coin.NextInt(); 
           // int coin = 0;
            if(toss>0)
                for(double i=0.1;i<toss;i++)
                if(i>0.5)
                {
                        Console.WriteLine(i);
                        Console.WriteLine("head");
                        head++;
                }
                    else
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("tail");
                        tail++;
                    }
            double headprecentege = (head / toss) * 100;
            double tailprecentage = (tail /toss) * 100;
            Console.WriteLine(headprecentege);
            Console.WriteLine(tailprecentage);
           

          }

        
    }
}

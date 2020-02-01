using System;
using System.Collections.Generic;
using System.Text;
using random;

namespace Logical_Programs
{
    class Gambler
    {
        public   void Gambler1()
        {
            Random rand = new Random();

            Console.WriteLine(" gambler's stating bankroll(amount)");
            double stake = Utility.Gambler();
            Console.WriteLine("gambler's desired bankroll (goal amount)");
            double goal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Number of trials to perform");
            double trials = Convert.ToDouble(Console.ReadLine());

            double bets = 0;
            double wins = 0;

            for (double t = 0.0; t < trials; t++)
            {
                double cash = stake;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    if (rand.NextDouble() < 0.5)
                        cash++;
                    else
                    cash--;
                }
                    if(cash == goal)
                    wins++;
                 
            }
        

           
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bets           = " + 1.0 * bets / trials);
        }



    }
}

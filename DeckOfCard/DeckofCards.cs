using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class DeckofCards
    {
        public void Cards()
        {
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] CardArray = new string[52];
            int start = 0, end = 12;
            int j1 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    CardArray[j] = suit[i] + " " + Rank[j1];
                    j1++;
                    Console.WriteLine(CardArray[j]);

                }

                j1 = 0;
                start = end + 1;
                end += 13;
            }
                Utility.SuffleCards(CardArray);
                for (int k = 0; k < 4; k++)
                {
                    
                    Console.WriteLine("player:" + k + " ");
                    // Utility.SuffleCards(CardArray);
                    for (int r = 0; r < 9; r++)
                    {
                        Console.WriteLine(CardArray[r]);
                    }
                }

            
        }
       
    }
}


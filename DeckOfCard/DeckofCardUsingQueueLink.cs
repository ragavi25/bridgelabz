using System;

namespace Object_oriented_programs
{
    class DeckofCardUsingQueueLink
    {
       // public object Arrays { get; private set; }

        public void DeckQueue()
        {
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] CardArray = new string[52];
            QueueImplementedUsingLinkedList<string> queue = new QueueImplementedUsingLinkedList<string>();
            int k = 0;
            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < Rank.Length; j++)
                {
                    CardArray[k] = suit[i] + " " + Rank[j];
                    k++;
                }
            }
            string card = Utility.SuffleCards(CardArray);
            string[] arr = new string[9];
            string temp1, temp2, temp3, temp4;
            int p = 0;
            char[] n1 = new char[2];
            char[] n2 = new char[2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[j] = CardArray[p];
                    p++;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    temp1 = arr[j];
                    temp2 = arr[j + 1];
                    n1[0] = temp1[temp1.Length - 2];
                    n1[1] = temp1[temp1.Length - 1];
                    n2[0] = temp2[temp2.Length - 2];
                    n2[1] = temp2[temp2.Length - 1];

                    if (temp1 !=temp2)
                    {
                        temp3 = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp3;

                    }


                }
                queue.enqueue("for player" + i + " ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("player:" + i + " ");
                for (int j = 0; j < 9; j++)
                {
                    temp4 = arr[j].Substring(0, arr[j].Length - 2);
                    queue.enqueue(temp4 + " ");
                    Console.WriteLine(temp4);
                }
                //Console.WriteLine("player:" + i + " ");
            }
        }
    }
}
            

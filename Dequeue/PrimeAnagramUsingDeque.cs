using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagramUsingDeque
    {
        public static void PrintPrimeInQueue()
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("enter the   anagrams in queue");
            int n = Utility.number();
            int[] arr = Utility.Prime(Utility.PrimeNumbers(n));
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Utility.Anagram(arr[i], arr[j]))
                    {
                        queue.Enqueue(arr[i]);
                    }
                }
            }
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

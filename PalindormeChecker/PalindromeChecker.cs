using System;

namespace Datastructure
{
    class PalindromeChecker
    {
        public void Checker()
        {
            String str = "madam";
            String revFront = "";
            string revRear = "";
            DequeImplementedUsingLinkedList<string> deque = new DequeImplementedUsingLinkedList<string>();
            // inserting element in deque
            for (int i = 0; i < str.Length; i++)
            {
                deque.insertRear(str[i]);
            }

            // removing element from rear and getting the rear values
            for (int i = 0; i < str.Length; i++)
            {
                revRear += deque.GetRear();
                deque.removeRear();
            }
            // inserting element again in deque
            for (int i = 0; i < str.Length; i++)
            {
                deque.insertRear(str[i]);
            }
            // removing element from front and getting the front values
            for (int i = 0; i < str.Length; i++)
            {
                revFront += deque.GetFront();
                deque.removeFront();
            }
           
            Console.WriteLine("Rear delete : " + revRear);
            Console.WriteLine("Front delete : " + revFront);
            if (revRear.Equals(revFront))
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }
    }
}

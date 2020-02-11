using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeUsingDeueue
    {
        public static void Palindrome()
        {
            Console.WriteLine("eneter a string");
            string character = Utility.UserString();
            char[] chars = character.ToCharArray();
            bool b = CheckPalindrome(chars);
            if (b)
            {
                Console.WriteLine(character + " is a palindrome");
            }
            else
            {
                Console.WriteLine(character + " is not palindrome");
            }
        }
        internal static Boolean CheckPalindrome(char[] chars)
        {
            Dequeue<char> dequeue = new Dequeue<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                dequeue.AddRear(chars[i]);
            }
            dequeue.PrintDeQueue();
            int j = 0;
            while (j < chars.Length)
            {
                char c = dequeue.RemoveRear();
                if (chars[j] != c)
                {
                    return false;
                }
                Console.WriteLine(chars[j]);
                j++;
            }
            return dequeue.IsEmpty();
        }
    }
}

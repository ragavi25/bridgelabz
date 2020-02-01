using System;

namespace Datastructure
{
    internal class Deque<T>
    {
        private readonly string ch;

        public Deque(string ch)
        {
            this.ch = ch;
        }
        public void Reverse(string ch)
        {

            string Str = null;
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Str = Str + ch[i];
            }
            if (ch.Equals(Str))
            {
                Console.WriteLine("Its a Palindrome String");
            }
            else
            {
                Console.WriteLine("Its not a Palindrome String");
            }
        }



    }
}

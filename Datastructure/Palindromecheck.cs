using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
    class Palindromecheck
    {
        public void Palindromec()
        {
           Console.WriteLine("Enter a string");
            String ch = Utility.UserString();
            Deque<string> s = new Deque<string>(ch);
            s.Reverse(ch);

        }       
    }
}

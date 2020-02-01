using System;
using System.Collections.Generic;
using System.Text;

namespace AlogrithmPrograms
{
    class Question
    {
        public static Boolean search(int lo, int hi)
        {
            if ((hi - lo) == 1)

                return true;
            int v = (hi - lo);
            int mid = lo + v / 2;
            Console.WriteLine("Is it less than %d?  ", mid);
            return search(lo, mid);
            search(mid, hi);
        }

        public void ques()
        {

        

          int k = Convert.ToInt32(Console.ReadLine());
            int n = (int)Math.Pow(2, k);
            Console.WriteLine("Think of an integer between %d and %d\n", 0, n - 1);
         bool secret = search(0, n);
            Console.WriteLine("Your number is %d\n", secret);

        }
    }
}

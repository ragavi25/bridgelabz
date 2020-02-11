using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPatterns
{
    class Utility
    {
        public static string UserString()
        {
            string userstring = Console.ReadLine();
            return userstring;
        }
        public static int UserInt()
        {
            int userinteger = Convert.ToInt32(Console.ReadLine());
            return userinteger;
        }
    }
}

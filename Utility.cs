using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern
{
    class Utility
    {
        public static int UserInt()
        {
            int userInt = Convert.ToInt32(Console.ReadLine());
            return userInt;
        }
        public static string UserString()
        {
            string userstr = Console.ReadLine();
            return userstr;
        }
    }
}

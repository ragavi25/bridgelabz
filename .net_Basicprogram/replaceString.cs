using System;
using System.Collections.Generic;
using System.Text;

namespace basicprogram
{
    class Replace
    {
        public   void  ReplaceUsername()
        {
            String username;
           
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
             username = String.Concat("how are you!"+" "+username);
            Console.WriteLine(username);
            Console.ReadLine();
           
                 }
    }
}

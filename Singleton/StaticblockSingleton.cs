using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPatterns
{
    public sealed class StaticblockSingleton
    {
        private int count = 0;
        private StaticblockSingleton()
        {
            count++;
            Console.WriteLine("Counting value:" + count.ToString());
        }
        private static StaticblockSingleton Instance;
       static{
        try{
            Instance = new StaticBlockSingleton();
    }catch(Exception e){
            throw new RuntimeException("Exception occured in creating singleton instance");
}
    }
    

        public static StaticblockSingleton GetInstance
        {
            get
            {
                return StaticblockSingleton();
            }
        }
        public void PrintDetailsStudent()
        {
            Console.WriteLine("Enter student Details:");
            Console.WriteLine("Enter student id:");
            int id = Utility.UserInt();
            Console.WriteLine("Enter studentFirstname:");
            string name = Utility.UserString();
            Console.WriteLine("Enter student LastName:");
            string lastname = Utility.UserString();
            Console.WriteLine("Enter student address");
            string address = Utility.UserString();
            Console.WriteLine(id + "\n" + name + "\n" + lastname + "\n" + address);
            PrintDetailsTeacher();
        }
        public void PrintDetailsTeacher()
        {
            Console.WriteLine("enter teacher name");
            string name = Utility.UserString();
            Console.WriteLine("Enter the subject:");
            string s = Utility.UserString();
            Console.WriteLine(name + "\n" + s);
        }

    }
}

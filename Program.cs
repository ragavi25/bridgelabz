using System;

namespace DesiginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HI:
            Console.WriteLine("Enter your choice:\n1.Eager Initialization\n2.Lazy Initialization3.Threadsafe Initialization");
            int ch = Utility.UserInt();
            switch(ch)
            {
                case 1:
                    EagerSingleton eager = EagerSingleton.GetInstance;
                    eager.PrintDetailsStudent();
                    break;
                case 2:
                    LazySingleton lazy = LazySingleton.GetInstance;
                    lazy.PrintDetailsStudent();
                    break;
                case 3:
                    ThreadSafeSingleton threadSafe = ThreadSafeSingleton.GetInstance;
                    threadSafe.PrintDetailsStudent();
                    break;
                   
            }
            goto HI;
        }
    }
}

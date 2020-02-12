using System;

namespace DesiginPattern
{
    public sealed  class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static ThreadSafeSingleton instance = null;
        /// <summary>
        /// Thread Safe Singleton using lock. control the thread race condition in a multithreaded environment
        /// </summary>
      private static readonly object Instancelock = new object();
        /// <summary>
        /// 
        /// </summary>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                        instance = new ThreadSafeSingleton();
                    return instance;
                }
            }
        }

        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetailsStudent()
        { 
            ////
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
            ////
            Console.WriteLine("enter teacher name");
            string name = Utility.UserString();
            Console.WriteLine("Enter the subject:");
            string s = Utility.UserString();
            Console.WriteLine(name + "\n" + s);
        }



  }
}


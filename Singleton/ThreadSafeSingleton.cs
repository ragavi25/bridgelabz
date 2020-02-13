/ --------------------------------------------------------------------------------------------------------------------
// <copyright file=ThreadsafeSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DesiginPattern.Singleton
{
    public class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static ThreadSafeSingleton instance = null;
        /// <summary>
        /// Thread Safe Singleton using lock. control the thread race condition in a multithreaded environment
        /// </summary>
        private static readonly object Instancelock = new object();
        /// <summary>
        /// private constractor ensure that object is not instantied other than with in class itself.
        /// </summary>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {////this look using Threadsafe.
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
            //// Return a count value.
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetailsStudent()
        {
            ////Take the Student detatils.
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
            ////Take Teacher detatils
            Console.WriteLine("enter teacher name");
            string name = Utility.UserString();
            Console.WriteLine("Enter the subject:");
            string s = Utility.UserString();
            Console.WriteLine(name + "\n" + s);
        }



    }
}


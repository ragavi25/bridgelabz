// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.Singleton
{
    /// <summary>
    /// Class for the Eager Initialization of Design Pattern of Singleton.
    /// </summary>
    public class EagerSingleton
    {
        /// <summary>
        /// Intialization private count integer value.
        /// </summary>
        private static int count = 0;
        private static  EagerSingleton Instance = null;
        private EagerSingleton()
        {
            //// The instance of EagerSingleton Class is created at the time of class loading, this is the easiest method to create a Eagersingleton class.
            count++;
            Console.WriteLine("Counter value:" + count.ToString());

        }
        public static EagerSingleton GetInstance
        { 
            ////
           get
            {
                if (Instance == null)
                    Instance = new EagerSingleton();
                return Instance;
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

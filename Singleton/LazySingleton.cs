﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LazySingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DesiginPattern.Singleton
{
    /// <summary>
    /// Class for the Lazy Initialization of Design Pattern of Singleton
    /// </summary>
    public sealed class LazySingleton
    {
        /// <summary>
        /// 
        /// </summary>
        private static int count = 0;
        private static Lazy<LazySingleton> Instance = new Lazy<LazySingleton>();
        /// <summary>
        /// 
        /// </summary>
        private LazySingleton()
        {
            count++;
            Console.WriteLine("Count value:" + count.ToString());
        }
        public static LazySingleton GetInstance
        {//
            get
                {
                return new LazySingleton();
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

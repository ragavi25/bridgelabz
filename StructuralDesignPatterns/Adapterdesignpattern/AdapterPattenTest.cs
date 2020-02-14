﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterPattenTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern
{
    /// <summary>
    /// Purpose:Here is a test program to consume our adapter design pattern implementation.
    /// </summary>
    public class AdapterPattenTest
    {
        public static void Test()
        {
            Console.WriteLine("Object");
            TestObjectAdapter();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Class");
            TestClassAdapter();
        }
        private static void TestObjectAdapter()
        {
            ISocketAdapter sockad = new SocketObjAdapterImpl();
            {
                Volt V3 = getVolt(sockad, 3);
                Volt V12 = getVolt(sockad, 12);
                Volt v120 = getVolt(sockad, 120);
                Console.WriteLine("v3 volts using Object Adapter=" + V3.getVolts());
                Console.WriteLine("v12 volts using Object Adapter=" + V12.getVolts());
                Console.WriteLine("v120 volts using Object Adapter=" + v120.getVolts());

            }
        }
        private static void TestClassAdapter()
        {
            ISocketAdapter sockad = new SocketClassAdapterImpl();
            {
                Volt V3 = getVolt(sockad, 3);
                Volt V12 = getVolt(sockad, 12);
                Volt v120 = getVolt(sockad, 120);
                Console.WriteLine("v3 volts using Class Adapter=" + V3.getVolts());
                Console.WriteLine("v12 volts using Class Adapter=" + V12.getVolts());
                Console.WriteLine("v120 volts using Class Adapter=" + v120.getVolts());

            }
        }

        private static Volt getVolt(ISocketAdapter sockad, int v)
        {
            switch(v)
            {
                case 3:
                    return sockad.Get3Volt();
                case 12:
                    return sockad.Get12Volt();
                case 120:
                    return sockad.Get120Volt();
                default:
                    return sockad.Get120Volt();
            }
        }
    }
}

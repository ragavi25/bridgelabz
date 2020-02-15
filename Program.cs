using DesiginPattern.Factory_Pattern;
using DesiginPattern.ProtoTypeDesignPattern;
using DesiginPattern.Singleton;
using DesiginPattern.StructuralDesignPatterns;
using DesiginPattern.StructuralDesignPatterns.Adapterdesignpattern;
using System;

namespace DesiginPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            HI:
            Console.WriteLine("Enter your choice:\n1.Eager Initialization\n2.Lazy Initialization\n3.Threadsafe Initialization\n4.Factory Pattern\n5.PrototypePattern\n6.AdapterDesignPattern\n7.ProxyPattern\n8.ObserverPattern");
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
                case 4:
                    TestFactory testFactory = new TestFactory();
                    testFactory.TestFactoryObj();
                    
                    break;
                case 5:
                    TestPrototype.Test();
                    break;
                case 6:
                    AdapterPattenTest.Test();
                    break;
                case 7:
                    ProxyPatternText.Text();
                    break;
                case 8:
                    break;
            }
            Console.WriteLine("***********************************************************");
            goto HI;
        }
    }
}

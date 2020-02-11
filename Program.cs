
using System;

namespace DesiginPatterns
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter your Design Ptterns:\t 1.Creation patten");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Singleton1 a = Singleton1.GetInstance;
                    a.PrintDetailsStudent();
                    
                    break;
            }

            
            

        }
    }
}

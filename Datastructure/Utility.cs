using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Datastructure
{
    class Utility
    {
        public static int Userrow()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            return m;
        }
        public static int Usercol()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static int UserInput()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            return k;
        }
        public static string UserName()
        {
            string name = Console.ReadLine();
            return name;

        }
        public static int UserAcno()
        {
            int ACno = Convert.ToInt32(Console.ReadLine());
            return ACno;
        }
        public static int UserMoney()
        {
            int money = Convert.ToInt32(Console.ReadLine());
            return money;

        }
        public static int Usermonth()
        {
            int month = Convert.ToInt32(Console.ReadLine());
            return month;
        }
        public static int Userday()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            return day;
        }
        public static int Useryear()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            return year;
        }

        public static int Writtefile()
        {
            int[] num = new int[] { 5, 6, 7, 23, 8, 1, 4, 9, 10, 45, 67 };

            StreamWriter sw = new StreamWriter("num.txt");
            {

                foreach (int s in num)
                {
                    sw.WriteLine(s);
                    Console.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            /* string line="";
             using(StreamReader sr = new StreamReader("num1.txt"))
              {
                  while ((line = sr.ReadLine()) != null)
                  {
                      Console.WriteLine(line);
                  }
              }
          Console.ReadKey();*/
            // Console.WriteLine(s);
            return 0;
        }
        public static int Readfile()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/BridgeLabz/Desktop/number.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            return 0;
        }
        public static string UserString()
        {
            string ch = Console.ReadLine();
            return "0";
        }
    }
}






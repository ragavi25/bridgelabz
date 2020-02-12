using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_oriented_programs
{
    class Utility
    {     
        public static int Usernum()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static int UserChoice()
        {
            int Choice = Convert.ToInt32(Console.ReadLine());
            return Choice;
        }
        public static string UserName()
        {
            string name = Console.ReadLine();
            return name;
        }
        public static string Userweight()
        {
            string weight = Console.ReadLine();
            return weight;
        }
        public static int UserPrice()
        {
            int price = Convert.ToInt32(Console.ReadLine());
            return price;
        }
        public static string SuffleCards(string[] CardArray)
        {
            Random random = new Random();
            int player1, player2;

            string temp = "";


            for (int i = 0; i < 52; i++)
            {

                player1 = random.Next(51);
                player2 = random.Next(51);


                if (player1 != player2)
                {
                    temp = CardArray[player1];
                    CardArray[player1] = CardArray[player2];
                    CardArray[player2] = temp;

                    Console.WriteLine(temp);

                }

            }
            return "\0";
        }
        public static int Totalvalue(int numberof_shares, int share_price)
        {
            return numberof_shares * share_price;
        }

public  static string Details(string path, Object r)
        {



            try
            {
                string jsonread;
                using (var reader = new StreamReader(path)) 
                {
                    jsonread = reader.ReadToEnd();
                }
                Console.WriteLine(jsonread);
                var customerfromjson = JsonConvert.DeserializeObject<Object>(jsonread);

            }
            catch (Exception e)
            {
                Console.WriteLine("The file not read");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            return "0";

        }
        public static string userstring()
        {
            string user = Console.ReadLine();
            return user;
        }
        public static string Writterfile(string path,Object r)
        {
           
            var jsonwrite = JsonConvert.SerializeObject(r, Formatting.Indented);
            var writter = new StreamWriter(path);
            writter.Write(jsonwrite);
            return "";
        }



    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_oriented_programs
{
    class Stock
    {
        public void Stock_All()
        {
            

            string Details()
            {



                try
                {
                    string jsonread;
                    using (var reader = new StreamReader("C:/Users/BridgeLabz/source/repos/Object oriented programs/Stock1.json"))
                    {
                        jsonread = reader.ReadToEnd();
                    }
                    Console.WriteLine(jsonread);
                    var customerfromjson = JsonConvert.DeserializeObject<Stockmodel>(jsonread);

                }
                catch (Exception e)
                {
                    Console.WriteLine("The file not read");
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                return "0";

            }
             int GetStockmodel()
            {

                Stockmodel data = new Stockmodel();
                kitkat k = new kitkat();
                snickers s = new snickers();
                lotte l = new lotte();

                Console.WriteLine("-----------------------------Stock Report--------------------------------");
                Console.WriteLine("Stock Name: " + data.getkitkat(), k.getstock_name());
                Console.ReadLine();
                Console.WriteLine("Stock Price: " + data.getkitkat(), k.getshare_price());
                Console.ReadLine();
                Console.WriteLine("Stock Number of Shares: " + data.getkitkat(), k.getnumber_of_shares());
                Console.ReadLine();
                int totalvalue_ofkitkat = Utility.Totalvalue(k.getnumber_of_shares(), k.getshare_price());
                Console.WriteLine("Total value of Stock Kitkats -->" + totalvalue_ofkitkat);
                k.settotalvalue_ofkitkat(totalvalue_ofkitkat);
                Console.ReadLine();

                Console.WriteLine("Stock Name: " + data.getsnickers(), s.getstock_name());
                Console.ReadLine();
                Console.WriteLine("Stock Price: " + data.getkitkat(), s.getshare_price());
                Console.ReadLine();
                Console.WriteLine("Stock Number of Shares: " + data.getkitkat(), s.getnumber_of_shares());
                Console.ReadLine();
                int totalvalue_ofsnickers = Utility.Totalvalue(s.getnumber_of_shares(), s.getshare_price());
                Console.WriteLine("Total value of Stock Kitkats -->" + totalvalue_ofsnickers);
                s.settotalvalue_ofsnickers(totalvalue_ofsnickers);
                Console.ReadLine();

                Console.WriteLine("Stock Name: " + data.getlotte(), l.getstock_name());
                Console.ReadLine();
                Console.WriteLine("Stock Price: " + data.getlotte(), l.getshare_price());
                Console.ReadLine();
                Console.WriteLine("Stock Number of Shares: " + data.getlotte(), l.getnumber_of_shares());
                int totalvalue_oflotte = Utility.Totalvalue(l.getnumber_of_shares(), l.getshare_price());
                Console.WriteLine("Total value of Stock lotte -->" + totalvalue_ofsnickers);
                s.settotalvalue_ofsnickers(totalvalue_ofsnickers);
                Console.ReadLine();

                int totalvalueof_allstock = totalvalue_ofkitkat + totalvalue_ofsnickers + totalvalue_oflotte;

                data.settotalvalueof_allstock(totalvalueof_allstock);
                Console.ReadLine();
                Console.WriteLine("Total count of all stocks -->" + totalvalueof_allstock);
                Console.ReadLine();
                Console.WriteLine("-----------------------------Stock Result--------------------------------");
               // Writterfile();
                return 0;
            }
            void Writterfile()
            {

                var stock = GetStockmodel();
                var jsonwrite = JsonConvert.SerializeObject(stock, Formatting.Indented);
                var writter = new StreamWriter("C:/Users/BridgeLabz/source/repos/Object oriented programs/stockoutput.json");
                writter.Write(jsonwrite);

                Console.WriteLine("\nWrite into file is completed!!!");

            }

            Details();
            Writterfile();

        }
    }
}


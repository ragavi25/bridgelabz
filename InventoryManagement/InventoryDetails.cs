using Newtonsoft.Json;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Stripe;
using System;
using System.Collections.Generic;
using System.IO;


namespace Object_oriented_programs
{
public class InventoryDetails
    {
        private order orders_wheats;

        public order Orders_pulses { get;  set; }
        public order Order_rice { get; private set; }

        //private string name;



        public string Details()
        {
           
            

                try
                {
                    string jsonread;
                    using (var reader = new StreamReader("C:/Users/BridgeLabz/source/repos/Object oriented programs/Data.json"))
                    {
                        jsonread = reader.ReadToEnd();
                    }
                    Console.WriteLine(jsonread);
                    var customerfromjson = JsonConvert.DeserializeObject<Inventorymodule>(jsonread);

                }
                catch (Exception e)
                {
                    Console.WriteLine("The file not read");
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            return "0";
            
        }
        public void Writterfile()
        {
            var Inventorymodule = GetInventorymodule();
            var jsonwrite = JsonConvert.SerializeObject(Inventorymodule, Formatting.Indented);
            var writter = new StreamWriter("C:/Users/BridgeLabz/source/repos/Object oriented programs/Data.json");
            writter.Write(jsonwrite);
        }

        internal order getWheats()
        {
            return orders_wheats; 
        }

        internal order getPulses()
        {
           return Orders_pulses;
        }

        internal order getRice()
        {
            return Order_rice;
        }

        public int GetInventorymodule()
        {
            var customer = new Inventorymodule()
            {
                id = 1,
                name = "mr",
                location = new Location()
                {
                    City = "Theni",
                    state = "TamilNadu",
                },
                Orders_rice = new List<order>
                {
                    new order
                    {
                        id = 1,
                        item1 = new List<Rice>
                        {
                            new Rice
                            {
                                product = new Product_rice()
                                {
                                    name = "Indica",
                                    price = 60
                                },
                                weight = "1kg"
                            },
                        }
                },   },
                Orders_pulses = new List<order>
                {
                    new order
                    {
                        id = 2,
                        item2 = new List<Pulses>
                        {
                            new Pulses
                            {
                                product = new Product_pulses()
                                {
                                    name = "spilt",
                                    price = 50
                                },
                                weight = "1kg"
                            },
                        }
                    },
                },
                Orders_wheats = new List<order>
               {
                         new order
                         {
                             id=3,
                             item3=new List<Wheats>
                             {
                             new Wheats
                             {
                               //Product =new Product_wheats()
                               // {
                                    name="Runner beans",
                                    price=30,
                              //  },
                                weight=":2kg"
                             },

                             }

                         },
               }
            };
            return 0;
        }

        private class Product_wheats
        {
            public Product_wheats()
            {
            }

            public string name { get; set; }
            public int price { get; set; }
        }

      
    }
}

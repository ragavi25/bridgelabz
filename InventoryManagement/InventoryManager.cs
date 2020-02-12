using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class InventoryManager
    {

        private object pp;

        public object Orders_pulses { get; private set; }
        public object Orders_wheats { get; private set; }

        public void Inventory_manager()
        {
            Console.WriteLine("Hello Manager!!!");
            Console.WriteLine(" Lets Add some inventory");
            Console.WriteLine("How much inventory_Details you want to add");
            string old_path = "C:/Users/BridgeLabz/source/repos/Object oriented programs/Data.json";
            string new_path = "C:/Users/BridgeLabz/source/repos/Object oriented programs/Manegerfile.json";
            //  Inventorymodule module1 = new Inventorymodule();
           
            int choice;
            string name;
            int price;
            string weight;
            
            InventoryDetails model = new InventoryDetails();
           // new_path = model.Details();

            Inventorymodule m = new Inventorymodule();

            List<order> orders_rice = new List<order>();
            List<order> Orders_pulses = new List<order>();
            List<order> Orders_wheats = new List<order>();
            //model.Orders_rice.Add()
            orders_rice.Add(model.getRice());
            Orders_pulses.Add(model.getPulses());
            Orders_wheats.Add(model.getWheats());
            int num = Utility.Usernum();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("For adding pressing: \n1.  rice\n2.  pulses\n3.  wheats:");
                choice = Utility.UserChoice();
                switch (choice)
                {
                    case 1:
                        Rice rice = new Rice();
                        Product_rice pr = new Product_rice();

                        Console.WriteLine("Enter the name of brand: ");
                        name = Utility.UserName();
                        Console.WriteLine("Enter weight : ");
                        weight = Utility.Userweight();
                        Console.WriteLine("Enter price : ");
                        price = Utility.UserPrice();
                        pr.setname(name);
                        rice.setweight(weight);
                        pr.setprice(price);
                        //orders_rice.Add(rice);
                        //orders_rice.Add(pr);
                        break;
                    case 2:
                        Pulses p = new Pulses();
                        Product_pulses PP = new Product_pulses();
                        Console.WriteLine("Enter the name of brand: ");
                        name = Utility.UserName();
                        Console.WriteLine("Enter weight : ");
                        weight = Utility.Userweight();
                        Console.WriteLine("Enter price : ");
                        price = Utility.UserPrice();
                        PP.setname(name);
                        p.setweight(weight);
                        PP.setprice(price);
                        //   Orders_pulses.Add(pp);
                        // Orders_pulses.Add(p);
                        break;
                    case 3:
                        Wheats w = new Wheats();
                        Product_wheats pw = new Product_wheats();
                        Console.WriteLine("Enter the name of brand: ");
                        name = Utility.UserName();
                        Console.WriteLine("Enter weight : ");
                        weight = Utility.Userweight();
                        Console.WriteLine("Enter price : ");
                        price = Utility.UserPrice();
                        pw.setname(name);
                        w.setweight(weight);
                        pw.setprice(price);
                        // Orders_wheats.Add(pw);
                        // Orders_wheats.Add(w);
                        break;
                    default:
                        Console.WriteLine("Please select valid option!!");
                        continue;
                }

            }
            
            m.setRice(orders_rice);
            m.setpulses(Orders_pulses);
            m.setwheats(Orders_wheats);
            model.Writterfile();
            Console.WriteLine("adding the new jsonfile");


        }
    }
}


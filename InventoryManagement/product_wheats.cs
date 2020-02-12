using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class Product_wheats
    {
        public string name { get; set; }
        public int price { get; set; }
        public Product_wheats()
        {
        }




        public string getname()
        {
            return name;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getprice()
        {
            return price;
        }
        public void setprice(int price)
        {
            this.price = price;
        }
    }
}

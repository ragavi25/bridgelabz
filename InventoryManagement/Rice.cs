using System;

namespace Object_oriented_programs
{
    public class Rice
    {
        public Product_rice product;
        public string weight { get; set; }
       public string getweight()
        {
            return weight;
        }
        public void setweight(string weight)
        {
            this.weight = weight;
        }

        internal static void setprice(int price)
        {
            throw new NotImplementedException();
        }
    }
}
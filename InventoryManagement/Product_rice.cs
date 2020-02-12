namespace Object_oriented_programs
{
    public class Product_rice
    {
        public string name { get; set; }
        public int price { get; set; }
        public  Product_rice()
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
namespace Object_oriented_programs
{
    public class Wheats
    {
        internal int price;
        internal string name;
        Product_wheats product=new Product_wheats();

        public string weight { get; set; }
        private Product_wheats Product { get;  set; }

        public string getweight()
        {
            return weight;
        }
        public void setweight(string weight)
        {
            this.weight = weight;
        }
        
    }
}

   

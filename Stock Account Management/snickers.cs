namespace Object_oriented_programs
{
    public class snickers
    {
        private string stock_name;
        private int number_of_shares;
        private int share_price;
        private int totalvalue_ofsnickers;
        public string getstock_name()
        {
            return stock_name;
        }
        public void setstock_name(string stock_name)
        {
            this.stock_name = stock_name;
        }
        public int getnumber_of_shares()
        {
            return number_of_shares;
        }
        public void setnumber_of_shares(int number_of_shares)
        {
            this.number_of_shares = number_of_shares;
        }
        public int getshare_price()
        {
            return share_price;
        }
        public void setshare_price(int share_price)
        {
            this.share_price = share_price;
        }
        public int gettotalvalue_ofsnickers()
        {
            return totalvalue_ofsnickers;
        }
        public void settotalvalue_ofsnickers(int totalvalue_ofstock)
        {
            this.totalvalue_ofsnickers = totalvalue_ofstock;
        }

    }
}
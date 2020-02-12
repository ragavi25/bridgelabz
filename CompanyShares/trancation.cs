namespace Object_oriented_programs
{
  class trancation
    {
        private string trancation_id;
        private string buyer;
        private string seller;
        private int trancation_amt;
        private string datetime;
        public string gettrancationid()
        {
            return trancation_id;
        }
        public void settrancationid(string trancation_id)
        {
            this.trancation_id = trancation_id;
        }
        public string getbuyer()
        {
            return buyer;
        }
        public void setbuyer(string buyer)
        {
            this.buyer = buyer;
        }
        public string getseller()
        {
            return seller;










        }
        public void setseller(string seller)
        {
            this.seller = seller;
        }
        public int gettrancation_amt()
        {
            return trancation_amt;
        }
        public void settrancation_amt(int trancation_amt)
        {
            this.trancation_amt = trancation_amt;
        }
        public string getdatetime()
        {
            return datetime;
        }
        public void setdatetime(string datetime)
        {
            this.datetime = datetime;
        }
    }
}
namespace Object_oriented_programs
{
    public class company_share
    {
        private string company_symbol;
        private string company_name;
        private int company_shares;
        private int company_share_price;
        private int company_total_value;
        public string getcompanysymbol()
        {
            return company_symbol;
        }
        public void setcompanysymbol(string company_symbol)
        {
            this.company_symbol = company_symbol;
        }
        public string getcompanyname()
        {
            return company_name;
        }
        public void setcompanyname(string company_name)
        {
            this.company_name = company_name;
        }
        public int getcompanyshares()
        {
            return company_shares;
        }
        public void setcompanyshares(int company_shares)
        {
            this.company_shares = company_shares;
        }
        public int getcompanyshareprice()
        {
            return company_share_price;
        }
        public void setcompanyshareprice(int company_share_price)
        {
            this.company_share_price = company_share_price;
        }
        public int getcompanytotalvalue()
        {
            return company_total_value;
        }
        public void setcompanytotalvalue(int company_total_value)
        {
            this.company_total_value = company_total_value;
        }
    }
}
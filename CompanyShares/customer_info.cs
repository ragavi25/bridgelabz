namespace Object_oriented_programs
{
    public class customer_info
    {
        private string customer_name;
        private int customer_share;
        private int customer_balance;
        public string getcustomername()
        {
            return customer_name;
        }
        public void setcustomername(string customer_name)
        {
            this.customer_name = customer_name;
        }
        public int getcustomershare()
        {
            return customer_share;
        }
        public void setcustomershare(int customer_share)
        {
            this.customer_share = customer_share;
        }
        public int getcustomerbalance()
        {
            return customer_balance;
        }
        public void setcustomerbalance(int customer_balance)
        {
            this.customer_balance = customer_balance;
        }
    }
}
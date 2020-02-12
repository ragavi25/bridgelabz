using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class Customermodel
    {
        private List<customer_info> Customer_info;
        public List<customer_info>getcustomer_info()
        {
            return Customer_info;
        }
        public void setcustomer_info(List<customer_info>Customer_info)
        {
            this.Customer_info = Customer_info;
        }
    }
}

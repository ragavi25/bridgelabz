using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class Companysharemodel
    {
        private List<company_share> company_shares;
        private LinkedListNode<company_share> company_share;
        public List<company_share> getcompany_shares()
        {
           return company_shares;
        }
        public void setcompany_shares(List<company_share>company_shares)
        {
     this . company_shares = company_shares;
        }

        public  LinkedListNode<company_share> getCompany_shares()
        {
            return company_share;
        }

        
    }
}

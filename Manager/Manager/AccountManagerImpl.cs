using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fundoo.Model;
using Repository.Repository;

namespace Manager.Manager
{
   public class AccountManagerImpl :IAccountManger
    {
        
        private IAccountRep Repository;
        public AccountManagerImpl(IAccountRep repository)
        {
            this.Repository = repository;
        }
        public async Task<bool> Register(RegisterModel registerModel)
        {
            await this.Repository.CreateRegister(registerModel);
            return true;
            
        }
    }
}
 
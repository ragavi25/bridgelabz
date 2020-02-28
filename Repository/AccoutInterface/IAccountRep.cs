using Fundoo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
   public interface IAccountRep
    {
        public Task<int> CreateRegister(RegisterModel registerModel);
        public Task<bool> Login(string Email,string password);

    }
}

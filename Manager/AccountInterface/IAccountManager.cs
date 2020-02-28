using Fundoo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public interface IAccountManger
    {
        public Task<bool> Register(RegisterModel registerModel);
    }
}

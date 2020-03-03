using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fundoo.Model;
using Model.Model;
using Repository.Repository;

namespace Manager.Manager
{
   public class AccountManagerImpl :IAccountManger
    {
        
        private IAccountRep Repository;

        public AccountManagerImpl()
        {
        }

        public AccountManagerImpl(IAccountRep repository)
        {
            this.Repository = repository;
        }

        public Task<RegisterModel> EmailLogin(LoginModel loginModel)
        {
            return this.Repository.EmailLogin(loginModel);
        }

        public Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
        {
            return this.Repository.FaceBookLogin(loginModel);
        }

        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword)
        {
            return this.Repository.ForgotPassword(forgotPassword);
        }

        public string Login(LoginModel loginModel)
        {
            return this.Repository.Login(loginModel);
        }

        public async Task<bool> Register(RegisterModel registerModel)
        {
            await this.Repository.CreateRegister(registerModel);
            return true;
            
        }

        public async Task<string> ResetPassWord(ResetPassWord reset)
        {
           string a= await this.Repository.ResetPassWord(reset);
            return a ;
        }
    }
}
 
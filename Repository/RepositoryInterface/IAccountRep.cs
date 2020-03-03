using Fundoo.Model;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
   public interface IAccountRep
    {
        public Task<int> CreateRegister(RegisterModel registerModel);
        public string Login(LoginModel loginModel);
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword);
        public Task<string> ResetPassWord(ResetPassWord reset);
        public Task<RegisterModel> EmailLogin(LoginModel loginModel);
        public  Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
   }
}

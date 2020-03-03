using Fundoo.Model;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public interface IAccountManger
    {
        public Task<bool> Register(RegisterModel registerModel);
        public string Login(LoginModel loginModel);
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword);
        public Task<string> ResetPassWord(ResetPassWord reset);
        public Task<RegisterModel> EmailLogin(LoginModel loginModel);
        public Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
    }
}

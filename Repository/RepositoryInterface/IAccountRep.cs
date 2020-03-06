// -----------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ---------------------------------------------------------------------------------------------------------------------------------
using Fundoo.Model;
using Model.Model;
using System.Threading.Tasks;

namespace Repository.Repository
{
    /// <summary>
    /// Purpose:Using Intefacer get the all purpose of social login.
    /// </summary>
    public interface IAccountRep
    {
        public Task<int> CreateRegister(RegisterModel registerModel);
        public Task<string> Login(LoginModel loginModel);
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword);
        public Task<string> ResetPassWord(ResetPassWord reset);
        public Task<RegisterModel> EmailLogin(LoginModel loginModel);
        public  Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
   }
}

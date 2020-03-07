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
        /// <summary>
        /// Purpose:create user register.
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public Task<int> CreateRegister(RegisterModel registerModel);
        /// <summary>
        /// Purpose:create user login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<string> Login(LoginModel loginModel);
       /// <summary>
       /// Purpose:create user forgotpassword.
       /// </summary>
       /// <param name="forgotPassword"></param>
       /// <returns></returns>
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword);
       /// <summary>
       /// Purpose:create user ResetPassword.
       /// </summary>
       /// <param name="reset"></param>
       /// <returns></returns>
        public Task<string> ResetPassWord(ResetPassWord reset);
       /// <summary>
       /// Purpose:create user Emaillogin.
       /// </summary>
       /// <param name="loginModel"></param>
       /// <returns></returns>
        public Task<RegisterModel> EmailLogin(LoginModel loginModel);
       /// <summary>
       /// create user Facebooklogin.
       /// </summary>
       /// <param name="loginModel"></param>
       /// <returns></returns>
        public  Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
   }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Threading.Tasks;
using Fundoo.Model;
using Model.Model;
using Repository.Repository;

namespace Manager.Manager
{
    public class AccountManagerImpl :IAccountManger
    {
        //// AccountManager get the Repository.  
        private readonly IAccountRep Repository;
        /// <summary>
        /// purpose:Using TestCase
        /// </summary>
        public AccountManagerImpl()
        {
        }

        /// <summary>
        /// Purpose:passing the Repository.
        /// </summary>
        /// <param name="repository"></param>
        public AccountManagerImpl(IAccountRep repository)
        {
            this.Repository = repository;
        }
        /// <summary>
        /// Purpose:Get the Repository EmailLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<RegisterModel> EmailLogin(LoginModel loginModel)
        {
            return this.Repository.EmailLogin(loginModel);
        }
        /// <summary>
        /// Purpose:Get the Repository FacebookLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
        {
            return this.Repository.FaceBookLogin(loginModel);
        }
        /// <summary>
        /// Purpose:Get the Repository ForgotPassword.
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword)
        {
            return this.Repository.ForgotPassword(forgotPassword);
        }
        /// <summary>
        /// Purpose:Get the Repository Login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Login(LoginModel loginModel)
        {
            return  this.Repository.Login(loginModel);
        }
        /// <summary>
        /// Purpose:Get the Repository Register.
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public async Task<bool> Register(RegisterModel registerModel)
        {
            await this.Repository.CreateRegister(registerModel);
            return true;
            
        }
        /// <summary>
        /// Purpose:Get the Repository ResetPassword.
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
        public async Task<string> ResetPassWord(ResetPassWord reset)
        {
           string a= await this.Repository.ResetPassWord(reset);
            return a ;
        }
    }
}
 
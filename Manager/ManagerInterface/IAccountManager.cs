// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Fundoo.Model;
using Model.Model;
using System.Threading.Tasks;

namespace Manager.Manager
{
    /// <summary>
    /// Purpose:get the all Social login purpose.
    /// </summary>
    public interface IAccountManger
    {
        /// <summary>
        /// Purpose:Get the Register .
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public Task<bool> Register(RegisterModel registerModel);
        /// <summary>
        /// purpose:get the User login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Login(LoginModel loginModel);
        /// <summary>
        /// purpose:get the user  Forgot Password.
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        public Task<string> ForgotPassword(ForgotPasswordModel forgotPassword);
        /// <summary>
        /// purpose:get the user ResetPassword.
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
        public Task<string> ResetPassWord(ResetPassWord reset);
        /// <summary>
        /// Purpose:Get the User EmailLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<RegisterModel> EmailLogin(LoginModel loginModel);
        /// <summary>
        /// purpose:Get the User FacebookLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
    }
}

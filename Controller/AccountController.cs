// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using Fundoo.Model;
using Manager.Manager;
using Microsoft.AspNetCore.Mvc;
using Model.Model;
namespace Fundoo.Controller
{
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// Purpose:Using MicroControl Asp.net core.
        /// </summary>
        public readonly IAccountManger manager;
        public AccountController(IAccountManger managers)
        {
          this.manager = managers;
        }
        /// <summary>
        /// Purpose:Control the User Register.
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            try
            {
                bool result = await this.manager.Register(registerModel);
                return Ok(registerModel );
               
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Control the User Login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login([FromBody] LoginModel loginModel)
        {
            try
            {
                string responce = await this.manager.Login(loginModel);
                    return Ok(loginModel);
               
              //  return responce != null ? Ok(responce) : (ActionResult)BadRequest("user not register");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// purpose:Control the User ForgotPassword.
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordModel forgotPassword)
        {
            try
            {
                string result = await this.manager.ForgotPassword(forgotPassword);
                return Ok(new { result});

            }
            catch (Exception g)
            {
                return BadRequest(g.Message);
            }
        }
        /// <summary>
        /// purpose:Control the User ResetPassword.
        /// </summary>
        /// <param name="resetPass"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> Reset([FromBody] ResetPassWord resetPass)
        {
            try
            {
                string result = await manager.ResetPassWord(resetPass);
                return Ok(resetPass);
            }
            catch (Exception g)
            {
                return BadRequest(g.Message);
            }
        }
        /// <summary>
        /// purpose:control the user EmailLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Email")]
        public async Task<IActionResult> EmailLogin([FromBody] LoginModel loginModel)
        {
            try
            {
                 var r=this.manager.EmailLogin(loginModel);
               // if (responce != null)
               // {
                    return Ok(loginModel);
               // }
              //  else
               // {
                  //  return this.BadRequest("not register");
                //}
                ////return responce != null ? Ok(responce) : (IActionResult)BadRequest("user not register");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        } 
        /// <summary>
        /// Purpose:Control the user Facebook Login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FaceBookLogin")]
        public async Task<IActionResult> FacebookLogin([FromBody] LoginModel loginModel)
        {
            try
            {
                var result = this.manager.FaceBookLogin(loginModel);
                //if(result!=null)
               // {
                    return Ok(loginModel);
                //}
                //else
               // {
                  //  return this.BadRequest("not register");
                //}
               // return result != null ? Ok(result) : (IActionResult)BadRequest("User not Register");
            }
            catch (Exception h)
            {
                return BadRequest(h.Message);
            }
        }
    }
}
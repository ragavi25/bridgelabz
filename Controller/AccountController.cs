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
       

        //private readonly IAccountRep repository;
      public readonly IAccountManger manager;
      public AccountController(IAccountManger managers)
       {
          this.manager = managers;
           
       }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
           try
            {
                var result = await this.manager.Register(registerModel);
                return this.Ok(registerModel );
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("login")]
        public ActionResult login([FromBody] LoginModel loginModel)
        {
            RegisterModel registerModel = new RegisterModel();
            try
            {
                var responce = this.manager.Login(loginModel);
                if (responce != null)
                {
                    return this.Ok(responce);

                }
                return this.BadRequest("user not register");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }

        }
        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordModel forgotPassword)
        {
            try
            {
                var result = await this.manager.ForgotPassword(forgotPassword);
                return this.Ok(forgotPassword);

            }catch(Exception g)
            {
                return this.BadRequest(g.Message);
            }
        }
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> Reset([FromBody] ResetPassWord resetPass )
        {
            try
            {
                var result = await this.manager.ResetPassWord(resetPass);
                return this.Ok(resetPass);
            }
            catch(Exception g)
            {
                return this.BadRequest(g.Message);
            }
        }
        [HttpGet]
        [Route("Email")]
        public IActionResult EmailLogin([FromBody] LoginModel loginModel)
        {
            try
            {
                var responce = this.manager.EmailLogin(loginModel);
                if (responce != null)
                {
                    return this.Ok(responce);

                }
                return this.BadRequest("user not register");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        } 
        [HttpGet]
        [Route("FaceBookLogin")]
    public IActionResult FacebookLogin([FromBody] LoginModel loginModel)
        {
            try
            {
                var result = this.manager.FaceBookLogin(loginModel);
                if(result!=null)
                {
                    return this.Ok(result);
                }
                return this.BadRequest("User not Register");
            }
            catch (Exception h)
            {
                return this.BadRequest(h.Message);
            }
        }
    }


}
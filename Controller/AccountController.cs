using System;
using System.Threading.Tasks;
using Fundoo.Model;
using Manager.Manager;
using Microsoft.AspNetCore.Mvc;

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
        [Route("api/Register")]
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
    }
}
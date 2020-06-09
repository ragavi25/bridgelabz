using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Model;
using Model.Model.Admin;

namespace Fundoo.Controller
{
   
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager adminManager;
        public AdminController(IAdminManager manager)
        {
            adminManager = manager;
        }

        [HttpPost]
        [Route("addAdmin")]
        public async Task<ActionResult> AddAdmin([FromBody] Admins admins)
        {
            try
            {
                var result = await this.adminManager.AddAdmin(admins);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("loginAdmin")]
        public ActionResult LoginAdmin([FromBody] Adminlogin admins)
        {
            try { 
            var result = this.adminManager.LoginAdmin(admins);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("getList")]
        public IEnumerable<Adminlist> GetUserList()
        {
            var result = this.adminManager.GetList();
            return result;
        }
    }
}
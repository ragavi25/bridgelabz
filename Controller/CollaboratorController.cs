using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controller
{
    public class CollaboratorController : ControllerBase
    {
        private ICollaboratorManager collaborator;
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            collaborator = collaboratorManager;
        }
        [HttpPost]
        [Route("AddCollaborator")]
        public async Task<IActionResult> AddCollaborator(int id,string email, string senderemail, string receiveemail)
        {
            try
            {
                var result = await this.collaborator.AddCollaborator(id,email, senderemail, receiveemail);
                return Ok(new { result });
            } catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
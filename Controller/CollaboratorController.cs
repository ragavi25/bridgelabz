// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controller
{
    public class CollaboratorController : ControllerBase
    {
        /// <summary>
        /// Purpose:Get the CollaboratorManager.
        /// </summary>
        private ICollaboratorManager collaborator;
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            collaborator = collaboratorManager;
        }
        /// <summary>
        /// Purpose:Control the AddCollaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="senderemail"></param>
        /// <param name="receiveemail"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Purpose:Control the GetCollaborator.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCollaborator")]
        public async Task<IActionResult> GetCollaborator()
        {
            try
            {
                var result = this.collaborator.GetCollaborators();
                
                return Ok(new { result });                                                                                                                                                                                           
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:control the DeleteCollaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteCollaborator")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result =await this.collaborator.delete(id);
                return Ok(id);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
       
        
        
    }
}
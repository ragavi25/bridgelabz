// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Model.LabelModel;

namespace Fundoo.Controller
{
    public class LabelController : ControllerBase
    {
        private readonly ILabelManager labelManager;
        public LabelController(ILabelManager manager)
        {
            labelManager = manager;
        }
        /// <summary>
        /// Purpose:Control the AddLabel.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddLabel")]
        public async Task<IActionResult> AddLabel(string name, int id)
        {
            try
            {
                await this.labelManager.AddLabel(name, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the Getlabel.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getlabel")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Label> list = this.labelManager.GetLabels();
                return Ok(new { list });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:control the Updatelabel.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("updatelabel")]
        public async Task<IActionResult> update(int id, string name)
        {
            try {
                var a = this.labelManager.update(id, name);
                return Ok(new { a });
            }catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the DeleteLabel.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Deletelabel")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                 await this.labelManager.Delete(id);
                return Ok(id);
            }
            catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }
    }
}
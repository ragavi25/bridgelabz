using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Http;
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
        [HttpDelete]
        [Route("Deletelabel")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                var result = this.labelManager.Delete(id);
                return Ok(new { result });
            }
            catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }
    

    }
}
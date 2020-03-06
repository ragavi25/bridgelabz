using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Model.NodesModel;

namespace Fundoo.Controller
{

    public class NotesController : ControllerBase
    {
        private readonly INoteManager nodeManager;
        public NotesController(INoteManager manager)
        {
            nodeManager = manager;
        }
        [HttpPost]
        [Route("AddNote")]
        public async Task<IActionResult> AddNodes([FromBody] Nodes nodes)
        {
            try
            {
                var s = this.nodeManager.AddNode(nodes);
                return Ok(new { s });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetNotes()
        {
            try
            {
              List<Nodes> n= this.nodeManager.GetNotes();
                return Ok(n);
            }
            catch (Exception f)
            {
                return BadRequest(f.Message);
            }
        }
        [HttpGet]
        [Route("getid")]
        public async Task<IActionResult> Get(int id)
         {
            try
            {
                var list =  this.nodeManager.GetNote(id);
               return Ok(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, string tittle, string Decription, string color, string img)
        {
            Nodes nodes1 = new Nodes();
            try
            {
                  var a=this.nodeManager.Update(id,tittle,Decription,color,img);
                return Ok(new { a });
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
             await this.nodeManager.Delete(id);
                return Ok(id);
            }
            catch (Exception g)
            {
                return BadRequest(g.Message);
            }
        }

    }
}
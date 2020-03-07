// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
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
        /// <summary>
        /// Purpose:Control the Addnote.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddNote")]
        public async Task<IActionResult> AddNotes([FromBody] Nodes notes)
        {
            try
            {
                await this.nodeManager.AddNote(notes);
                return Ok(notes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the getnote.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Purpose:control the Getid.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getid")]
        public async Task<IActionResult> Get(int id)
         {
            try
            {
              this.nodeManager.GetNote(id);
               return Ok(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:control the Update note.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tittle"></param>
        /// <param name="Decription"></param>
        /// <param name="color"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, string tittle, string Decription, string color, string img)
        {
            Nodes nodes1 = new Nodes();
            try
            {
                var a = this.nodeManager.Update(id,tittle,Decription,color,img);
                return Ok(new { a });
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:control the Delete note.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
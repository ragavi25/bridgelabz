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
using Microsoft.AspNetCore.Http;
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
                await this.nodeManager.AddNotes(notes);
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
            
            try
            {
                 await this.nodeManager.Update(id,tittle,Decription,color,img);
                return Ok(id);
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
             var a= this.nodeManager.Delete(id);
                return Ok(id);
            }
            catch (Exception g)
            {
                return BadRequest(g.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the UploadImage.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UploadImage")]
        public async Task<IActionResult> Uploadimg(int id,string img)
        {
            try
            {
               await this.nodeManager.UploadImg(id, img);
                return Ok(id );
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the ChangeColor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("ChangeColor")]
        public async Task<IActionResult> Color(int id,string color)
        {
            try
            {
                await this.nodeManager.Color(id, color);
                return Ok(id);
            }
            catch (Exception d)
            {
                return BadRequest(d.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the Ispin.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Ispin")]
        public async Task<IActionResult> Ispin(int id)
        {
            try {
                await  this.nodeManager.Ispin(id);
                return Ok(id);
            }
            catch (Exception d)
            {
                return BadRequest(d.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the Unpin.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Unpin")]
        public async Task<IActionResult> Unpin(int id)
        {
            try
            {
                await  this.nodeManager.Unpin(id);
                return Ok(id);
            }
            catch (Exception h)
            {
                return BadRequest(h.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the IsArchive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("IsArchive")]
        public async Task<IActionResult> IsArchive(int id)
        {
            try
            {
              await this.nodeManager.IsArchive(id);
                return Ok(id);
            }
            catch (Exception h)
            {
                return BadRequest(h.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the unArchive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UnArchive")]
        public async Task<IActionResult> UnArchive(int id)
        {
            try
            {
             await  this.nodeManager.UnArchive(id);
                return Ok(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the GetArchive.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetArchive")]
        public async Task<IActionResult> Getarchive()
        {
            try
            {
                var result = this.nodeManager.GetArchive();
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the Reminder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Reminder")]
        public async Task<IActionResult> Reminder(int id,string Reminder)
        {
            try
            {
                var result = await this.nodeManager.Reminder(id, Reminder);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the GetBin.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBin")]
        public async Task<IActionResult> GetBin()
        {
            try
            {
                var result = this.nodeManager.GetBin();
                return Ok(new { result });
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Purpose:Control the Restore.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Restore")]
        public async Task<IActionResult> Restore(int id)
        {
            try
            {
                await this.nodeManager.Restore(id);
                return Ok(id);
            }
            catch (Exception E)
            {
                return BadRequest(E.Message);
            }
        }

    }
}
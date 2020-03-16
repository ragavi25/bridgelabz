// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Http;
using Model.Model.NodesModel;
using Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class NodeManagerImpl : INoteManager
    {
        /// <summary>
        /// Purpose:NoteManager get the Repository.
        /// </summary>
        private readonly INotes notesRep;

        public NodeManagerImpl()
        {
        }
        public NodeManagerImpl(INotes notesR)
        {
            notesRep = notesR;
        }
        /// <summary>
        /// Purpose:get the Repository Addnote using notemanager.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public async Task AddNotes(Nodes notes)
        {
          await  this.notesRep.AddNotes(notes);           
        }

        public Task<string> Color(int id, string color)
        {
            return this.notesRep.Color(id, color);
        }

        /// <summary>
        /// Purpose:create the detetenote using get the repository addnote.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            await this.notesRep.Delete(id);
        }

        public List<Nodes> GetArchive()
        {
            return this.notesRep.GetArchive();

        }

        public List<Nodes> GetBin()
        {
            return this.notesRep.GetBin();
        }

        /// <summary>
        /// Purpose:create the Getnote using get the Repository getnote.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  List<Nodes> GetNote(int id)
        {
            var a = this.notesRep.GetNote(id);
            return a;
        }
        /// <summary>
        /// Purpose:create the Getnote using get the Repository getnote.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetNotes()
        {
            return this.notesRep.GetNotes();
        }
        /// <summary>
        /// Purpose:create the IsArchive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> IsArchive(int id)
        {
            return this.notesRep.IsArchive(id);
        }
        /// <summary>
        /// Create the Ispin.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> Ispin(int id)
        {
            return this.notesRep.Ispin(id);
        }
        /// <summary>
        /// Purpose:Create the Reminder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        public Task<int> Reminder(int id, string Reminder)
        {
            return this.notesRep.Reminder(id, Reminder);
        }
        /// <summary>
        /// Purpose:Create the Restore.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> Restore(int id)
        {
            return await this.notesRep.Restore(id);
        }
        /// <summary>
        /// Purpose:Create a UnArchive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> UnArchive(int id)
        {
           return this.notesRep.UnArchive(id);
        }
        /// <summary>
        /// Purpose:Create the Unpin.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> Unpin(int id)
        {
            return this.notesRep.Unpin(id);
        }

        /// <summary>
        /// purpose:Create the Update Using get the Repository Update.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="tittle"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        public async Task Update(int nodeId, string tittle, string description, string changeColor, string addImg)
        {
             await this.notesRep.Update(nodeId,tittle,description,changeColor,addImg);
        }
        /// <summary>
        /// Purpose:Create a UploadImg.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public Task<string> UploadImg(int id, string img)
        {
            return this.notesRep.UploadImg(id, img);
        }
    }
}

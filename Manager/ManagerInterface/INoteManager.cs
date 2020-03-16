// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
using Model.Model.NodesModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
    public interface INoteManager
    {
        /// <summary>
        /// Purpose:create the addnote
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public Task AddNotes(Nodes notes);
        /// <summary>
        ///  Purpose:create the getnote.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetNotes();
        /// <summary>
        ///  Purpose:create the addnote
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Nodes> GetNote(int id);
        //public Task Update(int nodeId, string tittle, string description, DateTime? modifieddate, Nodes nodes);
        /// <summary>
        /// Purpose:create the delete note.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Delete(int id);
        /// <summary>
        /// Purpose:create the update note.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="tittle"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        public Task Update(int nodeId, string tittle, string description, string changeColor, string addImg);
       /// <summary>
       /// Purpose:Create a UploadImages.
       /// </summary>
       /// <param name="id"></param>
       /// <param name="img"></param>
       /// <returns></returns>
        public Task<string> UploadImg(int id, string img);
       /// <summary>
       /// Purpose:Create a Changecolors.
       /// </summary>
       /// <param name="id"></param>
       /// <param name="color"></param>
       /// <returns></returns>
        public Task<string> Color(int id, string color);
       /// <summary>
       /// Purpose:Create a Ispin.
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Task<bool> Ispin(int id);
       /// <summary>
       /// Purpose:Create a Unpin.
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Task<bool> Unpin(int id);
      /// <summary>
      /// Purpose:Create a IsArchive.
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        public Task<bool> IsArchive(int id);
       /// <summary>
       /// Purpose:Create a UnArchive.
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Task<bool> UnArchive(int id);
       /// <summary>
       /// Purpose:Create a GetArchive.
       /// </summary>
       /// <returns></returns>
        public List<Nodes> GetArchive();
        /// <summary>
        /// Purpose:create a Reminder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        public Task<int> Reminder(int id, string Reminder);
       /// <summary>
       /// Purpose:Create a GetBin.
       /// </summary>
       /// <returns></returns>
        public List<Nodes> GetBin();
        /// <summary>
        /// Create a Restore.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public Task<string> Restore(int id);
    }
}

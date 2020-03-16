// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
using Model.Model.NodesModel;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Repository.RepositoryInterface
{
    public interface INotes
    {
        /// <summary>
        /// Purpose:create a addnote.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public Task AddNotes(Nodes notes);
        /// <summary>
        /// Purpose:create a getnote.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetNotes();
        /// <summary>
        /// Purpose:create a getnote id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Nodes> GetNote(int id);
        /// <summary>
        /// Purpose:create a Update note.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tittle"></param>
        /// <param name="Decription"></param>
        /// <param name="color"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public Task Update(int id, string tittle, string Decription, string color, string img);
        /// <summary>
        /// purpose:create a Delete note. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Delete(int id);
        /// <summary>
        /// Purpose:Create a UploadImages.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public Task<string> UploadImg(int id, string img);
        /// <summary>
        /// Purpose:Create a Addcolor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public Task<string> Color(int id, string color);
        /// <summary>
        /// Purpose:Create a Pin.
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
        /// Purpose:Create a Archive.
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
        /// Purpose:Create a Reminder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        public Task<int> Reminder(int id, string Reminder);
        /// <summary>
        /// Purpose:Create a GetArchive List.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetArchive();
        /// <summary>
        /// Purpose:Create a BIN.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> IsBin(int id);
        /// <summary>
        /// Purpose:Create a GetBin list.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetBin();
        /// <summary>
        /// Purpose:Create a Restore the note.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<string> Restore(int id);
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
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
   
    }
}

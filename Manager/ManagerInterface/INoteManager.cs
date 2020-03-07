// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
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
        public Task AddNote(Nodes notes);
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
        /// Purpose:create the delete label.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Delete(int id);
        /// <summary>
        /// Purpose:create the update label.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="tittle"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        public Task Update(int nodeId, string tittle, string description, string changeColor, string addImg);
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.ManagerInterface;
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
        public async Task AddNote(Nodes notes)
        {
          await this.notesRep.AddNotes(notes);           
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
        /// purpose:Create the Update Using get the Repository Update.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="tittle"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        public  Task Update(int nodeId, string tittle, string description, string changeColor, string addImg)
        {
            return this.notesRep.Update(nodeId,tittle,description,changeColor,addImg);
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.Model.NodesModel;
using Repository.Context;
using Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Repository.RepositoryImpl
{
    /// <summary>
    /// Purpose:Implementation of Note Repository.
    /// </summary>
    public class NotesRep : INotes
    {
        /// <summary>
        /// Purpose:This Repository using UserContext for the affected the database.
        /// </summary>
        private readonly UserContext context;
        public NotesRep(UserContext user)
        {
            context = user;
        }
        /// <summary>
        /// Purpose:create the Addnote using note model.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public async Task AddNotes(Nodes notes)
        {
            Nodes note = new Nodes()
            {
                NodeId = notes.NodeId,
                Email=notes.Email,
                Tittle = notes.Tittle,
                Description = notes.Description,
                Createdate1 = notes.Createdate1,
                Modifieddate = notes.Modifieddate,
                Archive=notes.Archive,
                Pin=notes.Pin,
                ChangeColor=notes.ChangeColor,
                AddImg=notes.AddImg,
            };
           this.context.Nodes.Add(note);
          await Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// purpose:create the DeleteNote using the id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).FirstOrDefault();
            if(result!=null)
            {
                this.context.Nodes.Remove(result); 
            }
            await Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Purpose:Create the GetNote using all the note list.
        /// </summary>
        /// <returns></returns>
        public  List<Nodes> GetNotes()
        {
            return  this.context.Nodes.ToList();
        }
        /// <summary>
        /// purpose:Create the GetNote using get the specific note list.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Nodes> GetNote(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if(result!=null)
            {
               var a= this.context.Nodes.ToList();
                Task.Run(() => context.SaveChanges());
            }
            return null;
        }
        /// <summary>
        /// Purpose:create the Update note using specific part of note upadated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tittle"></param>
        /// <param name="Decription"></param>
        /// <param name="color"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public  Task Update(int id, string tittle, string Decription,string color,string img)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if(result != null)
            {
                result.Tittle = tittle;
                result.Description = Decription;
                result.ChangeColor = color;
                result.AddImg = img;   
                this.context.Nodes.Update(result);
               return Task.Run(() => context.SaveChanges());
            }
            return default;
        }
    }
}

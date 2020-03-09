// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.Model.Collaborators;
using Repository.Context;
using Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class CollaboratorRep : ICollaborator
    {
        /// <summary>
        /// Purpose:get the usercontext using all details updated database."
        /// </summary>
        private readonly UserContext context;
        public CollaboratorRep(UserContext user)
        {
            context = user;
        }
        /// <summary>
        /// Purpose:Create the AddCollaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="senderemail"></param>
        /// <param name="receiveemail"></param>
        /// <returns></returns>
        public async Task<int> AddCollaborator(int id,string email, string senderemail, string receiveemail)
        {
            var result = this.context.Nodes.Where(op => op.Email == email).FirstOrDefault();
            if(result!=null)
            {
                CollaboratorModel collaboratorModel = new CollaboratorModel();
                var res = this.context.registers.Where(op => op.Email == senderemail).FirstOrDefault();
                if(res!=null)
                {

                    collaboratorModel.SenderEmail = senderemail;
                    collaboratorModel.ReceiverEmail = receiveemail;
                    this.context.collaborators.Add(collaboratorModel);
                    return await Task.Run(() => context.SaveChanges());
                }
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create the Delete using the specific id deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> Delete(int id)
        {
            var result = this.context.collaborators.Where(op => op.NoteId == id).FirstOrDefault();
            if(result!=null)
            {
                this.context.collaborators.Remove(result);
            }
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Purpose:Create the GetCollaborators using get the all list.
        /// </summary>
        /// <returns></returns>
        public List<CollaboratorModel> GetCollaborators()
        {
            return this.context.collaborators.ToList();
        }
        //public async Task<int> Update( int id,string email,string receivedemail)
        //{
        //    var result = this.context.collaborators.Where(op => op.NoteId == id).FirstOrDefault();
        //    if(result!=null)
        //    {
        //        result.SenderEmail = email;
        //        result.ReceiverEmail = receivedemail;
        //         this.context.Update(result);
        //    }
        //  return await Task.Run(() => this.context.SaveChanges());
        //}
    }
}

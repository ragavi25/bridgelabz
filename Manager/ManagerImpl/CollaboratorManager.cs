// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.ManagerInterface;
using Model.Model.Collaborators;
using Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class CollaboratorManager : ICollaboratorManager
    {
        /// <summary>
        /// Purpose:get the CollaboratorRepository.
        /// </summary>
        private readonly ICollaborator collaborator;
        public CollaboratorManager(ICollaborator collaborators)
        {
            collaborator = collaborators;
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
            var a= await this.collaborator.AddCollaborator(id, email,senderemail, receiveemail);
            return a;
        }
        /// <summary>
        /// Purpose:Create the Delete Collaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> delete(int id)
        {
            return await this.collaborator.Delete(id);
        }
        /// <summary>
        /// Purpose:Create the Get Collaborator.
        /// </summary>
        /// <returns></returns>
        public List<CollaboratorModel> GetCollaborators()
        {
            return this.collaborator.GetCollaborators();
        }
        
        //public async Task<int> Update(int id, string email, string receivedemail)
        //{
        //    return await this.collaborator.Update(id, email, receivedemail);
        //}
    }
}

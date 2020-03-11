// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.Model.Collaborators;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
    public  interface ICollaborator
    {
        /// <summary>
        /// Purpose:Create the AddCollaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="senderemail"></param>
        /// <param name="receiveemail"></param>
        /// <returns></returns>
        public Task<int> AddCollaborator(int id,string email,string senderemail,string receiveemail);
        /// <summary>
        /// Purpose:Create the GetCollaborator.
        /// </summary>
        /// <returns></returns>
        public List<CollaboratorModel> GetCollaborators();
        /// <summary>
        /// Purpose:Create the Delete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> Delete(int id);
        
    }
}


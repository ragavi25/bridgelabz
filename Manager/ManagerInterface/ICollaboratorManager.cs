// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.Model.Collaborators;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
    public interface ICollaboratorManager
    {
        /// <summary>
        /// Purpose:Create the AddCollaborator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="senderemail"></param>
        /// <param name="receiveemail"></param>
        /// <returns></returns>
        public Task<int> AddCollaborator(int id,string email, string senderemail, string receiveemail);
        /// <summary>
        /// Purpose:Create the GetCollaborators.
        /// </summary>
        /// <returns></returns>
        public List<CollaboratorModel> GetCollaborators();
        
        //public Task<int> Update(int id, string email, string receivedemail);
        /// <summary>
        /// Purpose:Create the Delete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<int> delete(int id);
    }
}

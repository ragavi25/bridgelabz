using Manager.ManagerInterface;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class CollaboratorManager : ICollaboratorManager
    {
        private readonly ICollaborator collaborator;
        public CollaboratorManager(ICollaborator collaborators)
        {
            collaborator = collaborators;
        }
        public async Task<int> AddCollaborator(int id,string email, string senderemail, string receiveemail)
        {
            var a= await this.collaborator.AddCollaborator(id, email,senderemail, receiveemail);
            return a;
        }
    }
}

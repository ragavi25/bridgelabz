using Model.Model.Collaborators;
using Repository.Context;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class CollaboratorRep : ICollaborator
    {
        private readonly UserContext context;
        public CollaboratorRep(UserContext user)
        {
            context = user;
        }
        public async Task<int> AddCollaborator(int id,string email, string senderemail, string receiveemail)
        {
            var result = this.context.Nodes.Where(op => op.Email ==email).FirstOrDefault();
            if(result!=null)
            {
                CollaboratorModel collaboratorModel = new CollaboratorModel();
                var res = this.context.registers.Where(op => op.Email == senderemail).FirstOrDefault();
                if(res!=null)
                {

                    collaboratorModel.ReceiverEmail = senderemail;
                    collaboratorModel.ReceiverEmail = receiveemail;
                    this.context.collaborators.Add(collaboratorModel);
                    return await Task.Run(() => context.SaveChanges());
                }
            }
            return default;
        }
    }
}

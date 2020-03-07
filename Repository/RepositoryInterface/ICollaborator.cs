using Model.Model.Collaborators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public  interface ICollaborator
   {
        public Task<int> AddCollaborator(int id,string email,string senderemail,string receiveemail);
   }
}


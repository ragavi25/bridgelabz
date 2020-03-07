using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
    public interface ICollaboratorManager
    {
        public Task<int> AddCollaborator(int id,string email, string senderemail, string receiveemail);
    }
}

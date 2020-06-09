using Model.Model;
using Model.Model.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public interface IAdmin
    {
        Task<int> AddAdmin(Admins admins);
       string LoginAdmin(Adminlogin admins);

        List<Adminlist> GetList();

    }
}

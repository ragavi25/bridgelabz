using Model.Model;
using Model.Model.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface IAdminManager
    {
        Task<int> AddAdmin(Admins admins);
        string LoginAdmin(Adminlogin admins);
        List<Adminlist> GetList();
    }
}

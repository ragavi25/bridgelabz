using Manager.ManagerInterface;
using Model.Model;
using Model.Model.Admin;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdmin admin;
        public AdminManager(IAdmin adminrep)
        {
            admin = adminrep;
        }
        public Task<int> AddAdmin(Admins admins)
        {
            return this.admin.AddAdmin(admins);
        }

        public List<Adminlist> GetList()
        {
            return this.admin.GetList();
        }

        public string LoginAdmin(Adminlogin admins)
        {
            return this.admin.LoginAdmin(admins);
        }
    }
}

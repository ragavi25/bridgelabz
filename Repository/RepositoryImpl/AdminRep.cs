using Model.Model;
using Model.Model.Admin;
using Repository.Context;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class AdminRep : IAdmin
    {
        private readonly UserContext context;
        public AdminRep(UserContext userContext)
        {
            userContext = context;
        }
        public Task<int> AddAdmin(Admins admins)
        {
            Admins admin = new Admins()
            {
                Firstname = admins.Firstname,
                Lastname = admins.Lastname,
                Email = admins.Email,
                Password = admins.Password
            };
            this.context.Admins.Add(admins);
            ///var s = Task.Run(() => context.SaveChanges());
            return default;
        }

        public List<Adminlist> GetList()
        {
            return this.context.Adminlists.ToList<Adminlist>();
        }

        public string LoginAdmin(Adminlogin admins)
        {
            var result = this.context.Admins.Where(op => op.Email == admins.Email).FirstOrDefault();
            if(result!=null && this.checkpassword(admins.Email, admins.Password))
            {
                return "Login successful";
            }
            return default;
        }
        public bool checkpassword(string email,string password)
        {
            bool result = this.context.Admins.Where(op => op.Email == email && op.Password == password).FirstOrDefault().Password != null ? true : false ;
            return result;
            
        }
    }
}

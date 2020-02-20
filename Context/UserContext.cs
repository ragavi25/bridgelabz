using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement;

namespace EmployeeManagement
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext>options):base(options)
        {

        }
        /// <summary>
        /// Initial Property
        /// 
        /// </summary>
        public DbSet<Employees> employees { get; set; }

    }
}

using EmployeeManagement.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement;

namespace EmployeeManagement.Repository
{
    public class EmployeeRep
    {
        private  UserContext context;
        private readonly IConfiguration iconfiguration; 
        public EmployeeRep(UserContext userContext,IConfiguration configuration)
        {
            this.context = userContext;
            this.iconfiguration = configuration;
        }
        public EmployeeRep(UserContext context)
        {
            this.context = context;
            if (context.employees.Count()== 0)
            {
                context.employees.AddRange(
                    new Employees
                    {
                        Id = 1,
                        FirstName = "Ragavi",
                        LastName = "Rajendran",
                        Email = "raghavimr@gmail.com",
                        UserName = "RAGAVI",
                        Password = "214235",
                        Mobile = "232576854",
                        Address = "DSGDSFJHNSGFSFH"
                    },
                    new Employees
                    {
                        Id = 2,
                        FirstName = "RAMYA",
                        LastName = "VANCHI",
                        Email = "ramya@gmail.com",
                        UserName = "ramya",
                        Password = "w54dfg",
                        Mobile = "3255638",
                        Address = "FBGFH"
                    }
                    );
                context.SaveChanges();
            }
        }

        public Employees Employees { get; private set; }

        public IEnumerable<Employees> GetEmployees()
        {
            return context.employees.ToList();
        }
        public bool TryGetEmployee(int id,out Employees employees)
        {
            employees = context.employees.Find(id);
            return (employees != null);
           
        }
        public async Task<int> AddEmployeeAsync(Employees employees)
        {
            int rowAffected = 0;
            context.employees.Add(Employees);
            rowAffected = await context.SaveChangesAsync();
            return rowAffected;
        }
    }
}

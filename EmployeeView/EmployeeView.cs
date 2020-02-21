using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using EmployeeManagement.Repository;

namespace EmployeeManagement.EmployeeView
{
    public class EmployeeView : EmpView
    {
        private int id;
        IUserRepository repository = new EmployeeRep();
        public void getemployee(Employees employees)
        {
            id = this.id;
            this.repository.GetEmployeeData(id);
        }

        public bool Login(Employees employees)
        {
            bool responce = this.repository.Login(employees);
            return responce;
        }

        public void Register(Employees employees)
        {
            this.repository.AddEmployee(employees);
        }

        public void Update(Employees employees)
        {
            this.repository.UpdateEmployee(employees);
        }
    }
}

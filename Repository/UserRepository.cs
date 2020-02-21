using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public interface IUserRepository
    {
        IEnumerable<Employees> GetEmployees();
        void AddEmployee(Employees employee);
        void UpdateEmployee(Employees employee);
        Employees GetEmployeeData(int id);
        void DeleteEmployee(int id);
        bool Login(Employees employees);
    }
}

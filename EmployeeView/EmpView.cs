using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.EmployeeView
{
  public interface EmpView
    {
       bool Login(Employees employees);
        void Register(Employees employees);
        void Update(Employees employees);
        void getemployee(Employees employees);
        
    }
}

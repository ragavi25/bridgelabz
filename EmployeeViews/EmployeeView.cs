using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.EmployeeViews;
using EmployeeManagement.Model;
using EmployeeManagement.Repository;

namespace EmployeeManagement.EmployeeViews
{
    /// <summary>
    /// create emlpoyeeviews using interface of EmpView. 
    /// </summary>
    public class EmployeeView : IEmpView
    {
        /// <summary>
        /// 
        /// </summary>
        private int id;
        IUserRepository repository = new EmployeeRep();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void Add(Employees employee)
        {
            this.repository.AddEmployee(employee);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            this.repository.DeleteEmployee(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employees> Get()
        {
            return this.repository.GetAllEmployee();
        }

        public bool Login(string username, string password)
        {
            return this.repository.LoginEmployee(username, password);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void Update(Employees employee)
        {
            this.repository.UpdateEmployee(employee);
        }
    }
}

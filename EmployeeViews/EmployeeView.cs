// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Controller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
        /// get the repository for database connection
        /// </summary>
        private int id;
         IUserRepository repository = new EmployeeRep();
        /// <summary>
        /// add employees.
        /// </summary>
        /// <param name="employee"></param>
        public void Add(Employees employee)
        {
            this.repository.AddEmployee(employee);
        }
        /// <summary>
        /// Delete employess.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            this.repository.DeleteEmployee(id);
        }
        /// <summary>
        /// Get the all Employees.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employees> Get()
        {
            return this.repository.GetAllEmployee();
        }

        public bool Login(string email, string password)
        {
            return this.repository.LoginEmployee(email, password);
        }
        /// <summary>
        /// Update the employees
        /// </summary>
        /// <param name="employee"></param>
        public void Update(Employees employee)
        {
            this.repository.UpdateEmployee(employee);
        }
    }
}

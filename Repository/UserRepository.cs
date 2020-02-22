using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public interface IUserRepository
    {

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>
        /// Returns a list of all employees.
        /// </returns>
        IEnumerable<Employees> GetAllEmployee();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void AddEmployee(Employees employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void UpdateEmployee(Employees employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        void DeleteEmployee(int? userId);

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        bool LoginEmployee(string username, string password);

    }
}

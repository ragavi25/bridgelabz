// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Controller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.EmployeeViews
{
  public interface IEmpView
    {
      /// <summary>
      /// Get the all employees.
      /// </summary>
      /// <returns></returns>
        IEnumerable<Employees> Get();

        /// <summary>
        /// Adds the  employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Add(Employees employee);

        /// <summary>
        /// Updates th employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Update(Employees employee);

        /// <summary>
        /// Deletes the specified userId.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);

        /// <summary>
        /// Logins the UserName.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if Username and password exist else false.
        /// </returns>
        bool Login(string username, string password);


    }
}

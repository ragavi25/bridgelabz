// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Controller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using EmployeeManagement.EmployeeViews;

using EmployeeManagement.Model;
using Microsoft.AspNetCore.Mvc;



namespace EmployeeManagement.Controller
{
    /// <summary>
    /// using controller Microsoft.AspNetCore.Mvc.
    /// </summary>
    public class UserController : ControllerBase
    {
        /// <summary>
        /// logoin the employees controller
        /// </summary>
       
     public  IEmpView empView = new EmployeeView();
      
        [HttpGet]
        [Route("api/login")]
        public  ActionResult Login(string email,string password)
        {
           
            Employees employees = new Employees();
            employees.Email = email;
            employees.Password = password;
            try
            {
                bool responce = this.empView.Login(email, password);
                if(responce)
                {
                    return this.Ok(responce);

                }
                return this.BadRequest("user not register");
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Get the employees  controller
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/get")]
        public ActionResult GetEmployees()
        {
            try
            {
                IEnumerable<Employees> list = this.empView.Get();
                return this.Ok(list);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// delete the employees controller.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/delete")]
        public ActionResult DeleteEmployees(int userId)
        {
            try
            {
                this.empView.Delete(userId);
                return this.Ok(userId);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Add the employess controller.
        /// </summary>
        /// <param name="usertId"></param>
        /// <param name="Firstname"></param>
        /// <param name="LastName"></param>
        /// <param name="email"></param>
        /// <param name="UserName"></param>
        /// <param name="password"></param>
        /// <param name="Mobile"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/add")]
        public ActionResult AddEmployees( string Firstname,string LastName, string email, string password,string Mobile)
        {
            try
            {
                Employees employee = new Employees();
               employee.FirstName = Firstname;
                employee.LastName = LastName;
                employee.Email = email;
                employee.Password = password;
                employee.Mobile = Mobile;
                this.empView.Add(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Update the employees controller.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="mobile"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/update")]
        public ActionResult UpdateEmployees(string firstname,string lastname, string email, string password,string mobile)
        {
            try
            {
                Employees employee = new Employees()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    Password = password,
                    Mobile=mobile                };

                this.empView.Update(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }


    }

}
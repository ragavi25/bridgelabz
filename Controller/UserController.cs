using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.EmployeeViews;

using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;



namespace EmployeeManagement.Controller
{
    /// <summary>
    /// 
    /// </summary>

    public class UserController : ControllerBase
    {
         /// <summary>
         /// 
         /// </summary>
        
     public  EmpView empView = new EmployeeView();
        [HttpGet]
        [Route("api/login")]
        public ActionResult Login(string username,string password)
        {
           
            Employees employees = new Employees();
            employees.UserName = username;
            employees.Password = password;
            try
            {
                bool responce = this.empView.Login(username, password);
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
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/get")]
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
        /// 
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
        /// 
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
        public ActionResult AddEmployees(int usertId,string Firstname,string LastName, string email,string UserName, string password,string Mobile, string address)
        {
            try
            {
                Employees employee = new Employees();
                employee.Id = usertId;
                employee.FirstName = Firstname;
                employee.LastName = LastName;
                employee.Email = email;
                employee.UserName = UserName;
                employee.Password = password;
                employee.Mobile = Mobile;
                employee.Address = address;
                this.empView.Add(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// 
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
        public ActionResult UpdateEmployees(int userId, string firstname,string lastname, string email,string username, string password,string mobile, string address)
        {
            try
            {
                Employees employee = new Employees()
                {
                    Id = userId,
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    UserName = username,
                    Password = password,
                    Mobile=mobile,
                    Address = address
                };

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
// -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Controller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement;
namespace EmployeeManagement.Model
{
    public class Employees
    {
        private int ID;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string mobile;
        public string FirstName { get => this.firstName; set =>this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Email { get => this.email; set =>this. email = value; }
        public string Password { get =>this. password; set =>this. password = value; }
        public string Mobile { get =>this. mobile; set =>this. mobile = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement;
namespace EmployeeManagement.Model
{
    public class Employees
    {
        [Required]
        private int UserId;
        [Required]
        private string firstName;
        [Required]
        private string lastName;
        [Required]
        private string email;
        [Required]
        private string userName;
        [Required]
        private string password;
        [Required]
        private string mobile;
        [Required]
        private string address;

        public int Id { get => this.UserId; set =>this.UserId = value; }
        public string FirstName { get => this.firstName; set =>this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Email { get => this.email; set =>this. email = value; }
        public string UserName { get =>this. userName; set => this.userName = value; }
        public string Password { get =>this. password; set =>this. password = value; }
        public string Mobile { get =>this. mobile; set =>this. mobile = value; }
        public string Address { get => this.address; set =>this. address = value; }
    }
}

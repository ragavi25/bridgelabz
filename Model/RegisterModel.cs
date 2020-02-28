﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Model
{
    public class RegisterModel
    {
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        [Required]
        public string FirstName { get =>this.firstName; set =>this. firstName = value; }
        [Required]
        public string LastName { get => this.lastName; set =>this. lastName = value; }
        [Required]
        public string Email { get =>this. email; set =>this. email = value; }
        [Required]
        public string Password { get => this.password; set =>this. password = value; }
       [Key]
       public string Id { get =>this. id; set =>this. id = value; }
    }
}

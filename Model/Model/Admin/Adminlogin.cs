using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model.Admin
{
   public class Adminlogin
    {
        private string email;
        private string password;
        [Required]
        public string Email { get => this.email; set => this.email = value; }
        [Required]
        public string Password { get => this.password; set => this.password = value; }

    }
}

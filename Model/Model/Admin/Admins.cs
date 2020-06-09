using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model.Admin
{
  public  class Admins
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        
        public string Firstname { get =>this.firstname; set =>this.firstname = value; }
        public string Lastname { get =>this.lastname; set => this.lastname = value; }
      [Key]
        public string Email { get => this.email; set =>this.email = value; }
        public string Password { get =>this.password; set =>this.password = value; }
    }
}

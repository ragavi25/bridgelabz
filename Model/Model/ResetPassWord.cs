using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model
{
    public class ResetPassWord
    {
        private string email;
        private string password;
        private string confirmpassword;
        private string token;
        [Required]
        public string Email { get => this.email; set => this.email = value; }
        [Required]
        public string Password { get => this.password; set =>this. password = value; }
        [Required]
        public string Confirmpassword { get => this.confirmpassword; set =>this. confirmpassword = value; }
       }
}




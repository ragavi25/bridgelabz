using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model
{
    public class ForgotPasswordModel
    {
        private string email;
        [Required]
        [EmailAddress]
        public string Email { get => this.email; set =>this. email = value; }
    }
}
 

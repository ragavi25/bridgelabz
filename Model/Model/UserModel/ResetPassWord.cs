// --------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ---------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Model.Model
{
    public class ResetPassWord
    {
        private string email;
        private string password;
        private string confirmpassword;
      
        [Required]
        public string Email { get => this.email; set => this.email = value; }
        [Required]
        public string Password { get => this.password; set =>this. password = value; }
        [Required]
        public string Confirmpassword { get => this.confirmpassword; set =>this. confirmpassword = value; }
    }
}




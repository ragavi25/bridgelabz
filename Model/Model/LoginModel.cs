// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------ss
using System.ComponentModel.DataAnnotations;

namespace Model.Model
{
    public class LoginModel
    {
        private string email;
        private string password;
        [Required]
        public string Email { get =>this. email; set => this.email = value; }
        [Required]
        public string Password { get => this.password; set =>this. password = value; }
    }
}

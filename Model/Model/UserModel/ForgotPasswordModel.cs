// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

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
 

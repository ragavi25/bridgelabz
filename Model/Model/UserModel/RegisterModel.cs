// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Fundoo.Model
{
    public class RegisterModel
    {
        public bool Status;
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string profilePicture;
        public string FirstName { get =>this.firstName; set =>this. firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Email { get =>this. email; set =>this. email = value; }
        public string Password { get => this.password; set =>this. password = value; }
        [Key]
        public string Id { get =>this. id; set =>this. id = value; }
        public string ProfilePicture { get => profilePicture; set => profilePicture = value; }
    }
}

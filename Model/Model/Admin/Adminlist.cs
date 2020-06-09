using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model
{
  public  class Adminlist
    {
        private int id;
        private string email;
        private DateTime logintime;
        [Key]
        public int Id { get =>this.id; set =>this.id = value; }
        public string Email { get =>this.email; set =>this.email = value; }
        public DateTime Logintime { get => this.logintime; set =>this.logintime = value; }
    }
}

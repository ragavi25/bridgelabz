// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model.NodesModel
{
   public class Nodes
   {
        private int nodeId;
        private string tittle;
        private string email;
        private string description;
        private DateTime? createdate;
        private DateTime? modifieddate;
        private bool archive;
        private bool pin;
        private string changeColor;
        private string addImg;
        [Key]
        public int NodeId { get =>this.nodeId; set =>this.nodeId = value; }
       
        public string Tittle { get =>this.tittle; set =>this.tittle = value; }
        public string Description { get =>this.description; set =>this.description = value; }
        public DateTime? Createdate1 { get =>this.createdate; set =>this.createdate = value; }
        public DateTime? Modifieddate { get => this.modifieddate; set => this.modifieddate = value; }
        public bool Archive { get => this.archive; set =>this. archive = value; }
        public bool Pin { get => this.pin; set =>this.pin = value; }
        public string ChangeColor { get => this.changeColor; set =>this.changeColor = value; }
        public string AddImg { get =>this.addImg; set =>this.addImg = value; }
        public string Email { get => this.email; set => this.email = value; }
    }
}

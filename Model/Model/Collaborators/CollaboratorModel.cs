// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Model.Model.Collaborators
{
    public class CollaboratorModel
  {
        private int noteId;
        private string senderEmail;
        private string receiverEmail;
        public int NoteId { get =>this.noteId; set =>this.noteId = value; }
         [Key]
        public string SenderEmail { get =>this.senderEmail; set =>this.senderEmail = value; }
        public string ReceiverEmail { get =>this.receiverEmail; set =>this.receiverEmail = value; }
  }
}

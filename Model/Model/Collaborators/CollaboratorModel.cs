using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model.Collaborators
{
  public class CollaboratorModel
  {
        private int noteId;
        private string senderEmail;
        private string receiverEmail;
        [Key]
        public int NoteId { get =>this.noteId; set =>this.noteId = value; }
        public string SenderEmail { get =>this.senderEmail; set =>this.senderEmail = value; }
        public string ReceiverEmail { get =>this.receiverEmail; set =>this.receiverEmail = value; }
  }
}

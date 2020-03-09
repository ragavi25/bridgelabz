// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Model.Model.LabelModel
{

    public class Label
    {
        private int labelId;
        private int noteid;
        private string labelname;
        //private Nodes nodeid;
        
        public int LabelId { get =>this.labelId; set =>this.labelId = value; }
        public string LabelName { get =>this.labelname; set =>this.labelname = value; }
      //  public Nodes Nodeid { get =>this. nodeid; set =>this. nodeid = value; }
        public int Noteid { get =>this. noteid; set => this.noteid = value; }
    }
}

using Model.Model.NodesModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model.LabelModel
{

    public class Label
    {
        private int labelId;
        private int noteid;
        private string labelname;
        //private Nodes nodeid;

        [Key]
        public int LabelId { get =>this.labelId; set =>this.labelId = value; }
        public string LabelName { get =>this.labelname; set =>this.labelname = value; }
      //  public Nodes Nodeid { get =>this. nodeid; set =>this. nodeid = value; }
        public int Noteid { get =>this. noteid; set => this.noteid = value; }
    }
}

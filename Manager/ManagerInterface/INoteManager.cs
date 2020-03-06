using Model.Model.NodesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface INoteManager
   {
        public Task AddNode(Nodes nodes);
        public List<Nodes> GetNotes();
        public List<Nodes> GetNote(int id);
        //public Task Update(int nodeId, string tittle, string description, DateTime? modifieddate, Nodes nodes);
        public Task Delete(int id);
        public Task Update(int nodeId, string tittle, string description, string changeColor, string addImg);
    }
}

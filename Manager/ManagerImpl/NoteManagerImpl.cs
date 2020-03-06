using Manager.ManagerInterface;
using Model.Model.NodesModel;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class NodeManagerImpl : INoteManager
    {
        private readonly INotes notesRep;

        public NodeManagerImpl()
        {
        }

        public NodeManagerImpl(INotes notesR)
        {
            notesRep = notesR;
        }
        public  Task AddNode(Nodes notes)
        {
            return this.notesRep.AddNotes(notes);
            
        }

        public Task Delete(int id)
        {
            return this.notesRep.Delete(id);
        }

        public List<Nodes> GetNote(int id)
        {
            return this.notesRep.GetNote(id);
        }

        public List<Nodes> GetNotes()
        {
            return this.notesRep.GetNotes();
        }

        public Task Update(int nodeId, string tittle, string description, string changeColor, string addImg)
        {
            Nodes nodes = new Nodes();
            return this.notesRep.Update(nodeId,tittle,description,changeColor,addImg);
        }
    }
}

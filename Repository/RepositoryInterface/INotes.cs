using Model.Model.NodesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
    public interface INotes
    {
        public Task AddNotes(Nodes notes);
        public List<Nodes> GetNotes();
        public List<Nodes> GetNote(int id);
        public Task Update(int id, string tittle, string Decription, string color, string img);
        public Task Delete(int id);
       // Task Update(int nodeId, string tittle, string description, DateTime? modifieddate, string changeColor, string addImg);
    }
}

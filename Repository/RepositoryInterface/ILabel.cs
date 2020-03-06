using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.Model.LabelModel;

namespace Repository.RepositoryInterface
{
   public interface ILabel
   {

        public Task AddLabel(string name,int id);
        public List<Label> Getlabel();
        public Task Update(int id,string name);
        public Task Delete(int id);
   }
}

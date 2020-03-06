using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.Model.LabelModel;

namespace Manager.ManagerInterface
{
   public interface ILabelManager
   {
        public Task AddLabel(string name,int id);
        public List<Label> GetLabels();
        public Task update(int id, string name);
        public Task Delete(int id);
   }
}

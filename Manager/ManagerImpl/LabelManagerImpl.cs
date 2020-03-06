using Manager.ManagerInterface;
using Model.Model.LabelModel;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class LabelManagerImpl : ILabelManager
    {
        private readonly ILabel label;
        public LabelManagerImpl(ILabel labels )
        {
            label = labels;
        }
        public Task AddLabel(string name,int id)
        {
            return this.label.AddLabel(name,id);
        }

        public Task Delete(int id)
        {
            return this.label.Delete(id);
        }

        public List<Label> GetLabels()
        {
            return this.label.Getlabel();
        }

        public Task update(int id, string name)
        {
            return this.label.Update(id, name);
        }
    }
}

using Model.Model.LabelModel;
using Repository.Context;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class LabelRep : ILabel
    {
        private readonly UserContext context;
        public LabelRep(UserContext user)
        {
            context = user;
        }
        public Task AddLabel(string name,int id)
        {
            Label label1 = new Label()
            {
                LabelName = name,
                Noteid=id,
            };

            this.context.labels.Add(label1);
         var res = Task.Run(() => context.SaveChanges());
            return res;

        }

        public Task Delete(int id)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).FirstOrDefault();
            if(result!=null)
            {
                this.context.labels.Remove(result);
            }
            return Task.Run(() => context.SaveChanges());

        }

        public List<Label> Getlabel()
        {
            return this.context.labels.ToList();
        }

        public Task Update(int id,string name)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).FirstOrDefault();
            if(result!=null)
            {
                result.LabelName = name;
               var res= Task.Run(() => context.SaveChanges());
                return res;
            }
            return default;
        }
    }
}

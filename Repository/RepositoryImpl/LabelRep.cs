// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Model.Model.LabelModel;
using Repository.Context;
using Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class LabelRep : ILabel
    {
        /// <summary>
        /// Purpose:This Repository using UserContext for the affected the database.
        /// </summary>
        private readonly UserContext context;
        public LabelRep(UserContext user)
        {
            context = user;
        }
        /// <summary>
        ///Purpose: create the Addlabel using label model
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Purpose:Create the Deletelabel using label id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async  Task Delete(int id)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).FirstOrDefault();
            if(result!=null)
            {
                this.context.labels.Remove(result);
            }
           await Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Purpose:create the Getlabel using get the all the label list.
        /// </summary>
        /// <returns></returns>
        public List<Label> Getlabel()
        {
            return this.context.labels.ToList();
        }
        /// <summary>
        /// Purpose:Create the Update label using specific part of upadated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
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

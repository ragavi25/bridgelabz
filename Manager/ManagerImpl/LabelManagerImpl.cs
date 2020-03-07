// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using Manager.ManagerInterface;
using Model.Model.LabelModel;
using Repository.RepositoryInterface;
using System.Collections.Generic;
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
        /// <summary>
        /// Purpose:create the Addlabel.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task AddLabel(string name,int id)
        {
            return this.label.AddLabel(name,id);
        }
        /// <summary>
        /// Purpose:create the Deletelabel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            await this.label.Delete(id);
        }
        /// <summary>
        ///Purpose:create the GetallLabel.
        /// </summary>
        /// <returns></returns>
        public List<Label> GetLabels()
        {
            return this.label.Getlabel();
        }
        /// <summary>
        /// Purpose:create the Updatelabel.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task update(int id, string name)
        {
            return this.label.Update(id, name);
        }
    }
}

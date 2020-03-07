// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Model.LabelModel;
namespace Manager.ManagerInterface
{
    public interface ILabelManager
    {
        /// <summary>
        /// Purpose:create the AddLabel.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task AddLabel(string name,int id);
        /// <summary>
        /// Purpose:create the Getlabel.
        /// </summary>
        /// <returns></returns>
        public List<Label> GetLabels();
       /// <summary>
       /// Purpose:create the Update.
       /// </summary>
       /// <param name="id"></param>
       /// <param name="name"></param>
       /// <returns></returns>
        public Task update(int id, string name);
       /// <summary>
       /// Purpose:create the delete.
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Task Delete(int id);
    }
}

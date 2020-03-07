// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Model.LabelModel;
namespace Repository.RepositoryInterface
{
    public interface ILabel
    {
        /// <summary>
        /// Purpose:create a AddLabel.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task AddLabel(string name,int id);
        /// <summary>
        /// Purpose:create a Getlabel.
        /// </summary>
        /// <returns></returns>
        public List<Label> Getlabel();
        /// <summary>
        /// Purpose:create a Update label.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task Update(int id,string name);
        /// <summary>
        /// Purpose:create a Delete label.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Delete(int id);
    }
}

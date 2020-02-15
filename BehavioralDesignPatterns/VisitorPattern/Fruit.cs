// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public class Fruit : ItemElement
    {
        private string Name;
        private int Weight;
        private int Priceperkg;
        private string v1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Weight"></param>
        /// <param name="Priceperkg"></param>

        
        public Fruit(string Name, int Weight, int Priceperkg)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Priceperkg = Priceperkg;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.Name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getWeight()
        {
            return Weight;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getPriceperkg()
        {
            return Priceperkg;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
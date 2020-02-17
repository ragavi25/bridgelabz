// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    /// <summary>
    ///  create some concrete classes for different types of items.
    /// </summary>
    public class Fruit : ItemElement
    {
        private string Name;
        private int Weight;
        private int Priceperkg;
        private string v1;

        public Fruit(string Name, int Weight, int Priceperkg)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Priceperkg = Priceperkg;
        }
        /// <summary>
        /// GetName use to get the visitor furit name..
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.Name;
        }
        /// <summary>
        /// Get the furit Weight.
        /// </summary>
        /// <returns></returns>
        public int getWeight()
        {
            return Weight;
        }
        /// <summary>
        /// Get the furit price
        /// </summary>
        /// <returns></returns>
        public int getPriceperkg()
        {
            return Priceperkg;
        }
        /// <summary>
        /// Accept the current visitor Accept in ShopingCard. 
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
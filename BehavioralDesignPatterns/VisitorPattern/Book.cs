// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Book : ItemElement
    {
        private readonly int Cost;
        private readonly string ISBNumber;
        private readonly int v1;
        private readonly string v2;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cost"></param>
        /// <param name="ISBNumber"></param>
        public Book(int Cost, string ISBNumber)
        {
            this.Cost = Cost;
            this.ISBNumber= ISBNumber;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getCost()
        {
            return Cost;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getISBNumber()
        {
            return ISBNumber;
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
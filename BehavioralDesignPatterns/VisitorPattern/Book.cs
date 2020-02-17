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
    public class Book : ItemElement
    {
        private readonly int Cost;
        private readonly string ISBNumber;
        private readonly int v1;
        private readonly string v2;
       
        public Book(int Cost, string ISBNumber)
        {
            this.Cost = Cost;
            this.ISBNumber= ISBNumber;
        }
        /// <summary>
        /// Getcost used to get the current amount .
        /// </summary>
        /// <returns></returns>
        public int getCost()
        {
            return Cost;
        }
        /// <summary>
        /// getISBNumer used to get the number of book isbn.
        /// </summary>
        /// <returns></returns>
        public string getISBNumber()
        {
            return ISBNumber;
        }
        /// <summary>
        /// Accept metod used to accept the shopingcard visitor.
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    /// <summary>
    /// We have visit() method for different type of items in Visitor interface that will be implemented by concrete visitor class.
    /// </summary>
    public interface ShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);

    }
}
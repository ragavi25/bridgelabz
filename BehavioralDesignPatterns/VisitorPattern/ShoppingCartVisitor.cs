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
    public interface ShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCardClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// -------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    /// <summary>
    /// Purpose:To implement visitor pattern, first of all we will create different type of items (Elements) to be used in shopping cart.
    /// </summary>
    public interface ItemElement
    {
        public int Accept(ShoppingCartVisitor visitor);
    }
}

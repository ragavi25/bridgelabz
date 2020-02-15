using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.BehavioralDesignPatterns.VisitorPattern
{
    public interface ItemElement
    {
        public int Accept(ShoppingCartVisitor visitor);
    }
}

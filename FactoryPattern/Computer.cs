// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
namespace DesiginPattern.Factory_Pattern
{/// <summary>
/// Purpose:Create an Abstract Computer Class.Super class in factory design pattern can be an interface.
/// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Ram declaration of get the value.This ram instance.
        /// </summary>
        /// <returns>current value of Ram</returns>
        public abstract string Ram();
        /// <summary>
        /// Cpu declaration of get the value.This cpu instance.
        /// </summary>
        /// <returns>Current value of Cpu</returns>
        public abstract string Cpu();
        /// <summary>
        /// Hdd declaration of get the value.This Hdd instance.
        /// </summary>
        /// <returns>Current value of Hdd</returns>
        public abstract string Hdd();
        /// <summary>
        ///  we have abstract super class with overridden toString() method for testing purpose.
        /// </summary>
        public new string ToString => "RAM= " + this.Ram() + ", CPU=" + this.Cpu() + ", HDD=" + this.Hdd();
    }
}

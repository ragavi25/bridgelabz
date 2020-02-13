// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ----------------------------------------------------------------------------------------
namespace DesiginPattern.Factory_Pattern
{/// <summary>
/// Purpose:Create an Abstract Computer Class.
/// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Ram declaration of get the value.
        /// </summary>
        /// <returns>curent value of Ram</returns>
        public abstract string Ram();
        /// <summary>
        /// Cpu declaration of get the value
        /// </summary>
        /// <returns>Curent value of Cpu</returns>
        public abstract string Cpu();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string Hdd();
        public new string ToString => "RAM= " + this.Ram() + ", CPU=" + this.Cpu() + ", HDD=" + this.Hdd();
    }
}

namespace DesiginPattern.Factory_Pattern
{/// <summary>
/// 
/// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string Ram();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string Cpu();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string Hdd();
        public new string ToString => "RAM= " + this.Ram() + ", CPU=" + this.Cpu() + ", HDD=" + this.Hdd();
    }
}

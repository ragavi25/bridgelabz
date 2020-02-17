// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TestPrototype.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// ---------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace DesiginPattern.ProtoTypeDesignPattern
{
    /// <summary>
    /// Purpose: Address class used to get the address.
    /// </summary>
    public class Address
    {
    public Address(string state, string city)
        {
            this.State = state;
            this.City = city;
        }

        public int DoorNum { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public override string ToString()
        {
            return string.Format("State : "+this.State+"  "+"City:"+this.City);
        }
        /// <summary>
        /// Address clone method used to clone the state and city.
        /// </summary>
        /// <returns></returns>
        public Address Clone()
        {
            return new Address( this.State, this.City );   
        }

        public Address DeepCopy()
        {

            string result = JsonConvert.SerializeObject(this);
            ////TO avoid memory referencing
            return JsonConvert.DeserializeObject<Address>(result);
        }
    }
}

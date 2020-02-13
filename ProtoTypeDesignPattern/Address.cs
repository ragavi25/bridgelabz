using Newtonsoft.Json;
using System;

namespace DesiginPattern.ProtoTypeDesignPattern
{
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

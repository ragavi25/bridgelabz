using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPattern.ProtoTypeDesignPattern
{
  public class Address
    {
      //  private int Doornum;
       // private string street;
        private string city;
        private string state;
      //  private int zipcode;

       

        public Address(string state, string city)
        {
            this.state = state;
            this.city = city;
        }

        public int DoorNum { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public override string ToString()
        {
            return string.Format("State : {0}"+"\n"+"city :{1}",this.State,this.City);
        }

        public Address Clone()
        {
            return new Address( this.State, this.City );   
        }
    }
}

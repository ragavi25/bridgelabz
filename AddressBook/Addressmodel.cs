
using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class Addressmodel
    {
        internal object a1;
        private int id;
        private string FirstName;
        private string LastName;
        private string state;
        private string city;
        private string street;
        private int zipcode;

        public int Id { get => this.id; set => this.id = value; }
        public string FirstName1 { get => this.FirstName; set => this.FirstName = value; }
        public string LastName1 { get => this.LastName; set => this.LastName = value; }
        public string State { get => this.state; set => this.state = value; }
        public string City { get => this.city; set => this.city = value; }
        public string Street { get => this.street; set => this.street = value; }
        public int Zipcode { get => this.zipcode; set => this.zipcode = value; }
    }
}

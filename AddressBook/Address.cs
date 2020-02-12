namespace Object_oriented_programs
{
    public class Address
    {
        private string state;
        private string city;
        private string street;
        private int zipcode;
        public string State { get =>this. state; set => this.state =value; }
        public string City { get => this.city; set =>this. city = value; }
        public string Street { get =>this. street; set =>this. street = value; }
        public int Zipcode { get => this.zipcode; set =>this. zipcode = value; }
    }
}
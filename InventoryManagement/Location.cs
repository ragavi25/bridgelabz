namespace Object_oriented_programs
{
    public class Location
    {
        public string City { get; set; }
        public string state { get; set; }
        public string getcity()
        {
            return City;
        }
        public void setcity()
        {
            this.City = City;
        }
        public string getstate()
        {
            return state;
        }
        public void setstate()
        {
            this.state = state;
        }
    }
}
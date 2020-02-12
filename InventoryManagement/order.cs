using System.Collections.Generic;

namespace Object_oriented_programs
{
    public class order
    {
        public int id { get; set; }
       public List<Rice> item1 { get; set; }

        public List<Pulses> item2 { get; set; }
        public List<Wheats> item3 { get; set; }

        public int getid()
        {
            return id;
        }
        public void setid()
        {
            this.id = id;
        }
    }
}
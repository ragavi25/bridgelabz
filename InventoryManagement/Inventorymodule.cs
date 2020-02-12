using System;
using System.Collections.Generic;

namespace Object_oriented_programs
{
    class Inventorymodule
    {
        public int id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public List<order> Orders_rice { get; set; }

        public List<order> Orders_pulses { get; set; }
        public List<order> Orders_wheats { get; set; }
        public int Weight { get; private set; }

        
            public int getWeight()
        {
            return Weight;
        }

        

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public object getRice()
        {
            return Orders_rice;
        }
       public void setRice(List<order> orders_rice)
        {
            this.Orders_rice = Orders_rice;
        }
        public object getPulses()
        {
            return Orders_pulses;
        }
        public void setPulses()
        {
            this.Orders_pulses = Orders_pulses;
        }

        public object getWheats()
        {
            return Orders_wheats;
        }
        public void setWheats()
        {
            this.Orders_wheats = Orders_wheats;
        }

        public void setpulses(List<order> orders_pulses)
        {
            this.Orders_pulses = orders_pulses;
        }

        public void setwheats(List<order> orders_wheats)
        {
            this.Orders_wheats = Orders_wheats;
        }
    }

      
    }


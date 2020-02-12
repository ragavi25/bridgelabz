using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class Stockmodel
    {
        private List<kitkat> kitkat;
        private List<snickers> snickers;
        private List<lotte> lotte;
        private int totalvalueof_allstock;
        public  List<kitkat>getkitkat()
        {
            return kitkat;
        }
        public void setkitkat(List<kitkat>kitkat)
        {
          this.kitkat = kitkat;
        }
        public List<snickers>getsnickers()
        {
            return snickers;
        }
        public void setsnickers(List<snickers> snickers)
        {
           this.snickers = snickers;
        }
        public List<lotte>getlotte()
        {
            return lotte;
        }
        public void setlotte(List<lotte>lotte)
        {
          this.lotte = lotte;
        }
        public int gettotalvalueof_allstock()
        {
            return totalvalueof_allstock;
        }
        public void settotalvalueof_allstock(int totalvalueof_allstock)
        {
          this.totalvalueof_allstock = totalvalueof_allstock;
        }
    }

}

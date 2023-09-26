using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
     public  class jugador : persona
    {
        int dorsal;


        public void setDorsal (int d)
        {
            this.dorsal = d;  
        }
        public int getDorsal()
        {
            return dorsal;
        }

        public new string presentar()
        {
            return (base.presentar() + "y tengo el dorsal " + dorsal);

        }


    }
}

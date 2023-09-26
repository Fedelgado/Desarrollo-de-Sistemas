using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public class entrenador : persona 
    {
        private tactica tacticas;


        public void setTactica(tactica t)
        {
            this.tacticas = t;

        }
        public tactica GetTactica()
        {
            return tacticas;

        }

        public new string presentar()
        {
           

            return (base.presentar() + " y mi tactica es: " + this.tacticas);


        }


    }
}

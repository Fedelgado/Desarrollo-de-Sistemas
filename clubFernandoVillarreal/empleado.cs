using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public class empleado : persona
    {
         string funcion;


        public void setFuncion (string f)
        {
            this.funcion = f;

        }

        public string getFuncion()
        {

            return this.funcion;

        }

        public new string presentar()
        {
    
            return (base.presentar() + "y trabajo como " + funcion);


        }

    }
}

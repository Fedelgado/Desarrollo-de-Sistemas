using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public abstract class persona
    {
         string nombre;
         string apellido;


        public void setNombre (string n)
        {

             this.nombre = n;
            
        }

        public string getNombre()
        {

            return nombre;

        }

        public void setApellido(string Apellido)
        {

            this.apellido = Apellido;

        }

        public string getApellido()
        {

            return this.apellido;

        }

        public string presentar()
        {
            
            
            return ("hola mi nombre es: " + this.nombre + " " + this.apellido + " ");



        }

    }
}

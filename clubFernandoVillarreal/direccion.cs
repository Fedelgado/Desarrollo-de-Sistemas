using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public class direccion
    {
        private string calle;
        private int altura;
        private string ciudad;

        public void setCalle(string calle)
        {
            this.calle = calle;
        }
        public string getCalle()
        {
            return this.calle;
        }
        public void setAltura(int altura)
        {
            this.altura = altura;
        }
        public int getAltura()
        {
            return this.altura;
        }

        public void setCiudad(string ciudad)
        {
            this.ciudad = ciudad;
        }
        public string getCiudad()
        {
            return this.ciudad;
        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empeñofernandoVillarreal
{
    internal class direccion
    {
        private string calle;
        private int altura;
        private int codigoPostal;

        public void setCalle (string c)
        {
            calle = c;
        }
        public string getCalle ()
        {
            return calle;
        }
        public void setAltura (int a)
        {
            altura = a;
        }
        public int getAltura()
        {
            return altura;
        }
        public void setcodigoPostal(int CP)
        {
            codigoPostal = CP;
        }
        public int getCodigoPostal()
        {
            return codigoPostal;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empeñofernandoVillarreal
{
    internal class casaEmpeño
    {
        private string nombre;
        private direccion direccion;
        public List<articulo> listaArticulos;

       

        public void setNombre(string n)
        {
            nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setDireccion(direccion d)
        {
            direccion = d;
        }
        public direccion getDireccion()
        {
            return direccion;
        }

        public casaEmpeño()
        {
            listaArticulos = new List<articulo>();
        }

        public void agregarArticulo (articulo art)
        {
            listaArticulos.Add(art);
        }
        public void removerArticulo(string nombre)
        {

            for (int i = listaArticulos.Count - 1; i >= 0; i--)
            {
                if (listaArticulos[i].getNombre() == nombre)
                {
                    listaArticulos.RemoveAt(i);
                }
            }



        }
        public string buscarArticulo (string nombre)
        {
            foreach (articulo a in listaArticulos)
            {
                if (a.getNombre() == nombre)
                {
                    return ("se ha encontrado el articulo: " + a.getNombre());
                }
                
            }
            return ("no se ha encontrado nada");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empeñofernandoVillarreal
{
    internal class articulo
    {
        private string nombre;
        private double precio;
        private bool enVenta;
        private CONDICION condicion;
        private CATEGORIA categoria;

        public void setNombre(string n)
        {
            nombre = n; 
        }
        public string getNombre () 
        {
            return nombre;
        }
        public void setprecio(double p) 
        { 
            precio = p;
        }
        public double getPrecio()
        {
            return precio;
        }
        public void setEnVenta(string n)
        {
            if (n == "no")
            {
                enVenta = false;
            }
            enVenta = true;
            
        }
        public bool getEnVenta()
        {
            return enVenta; 
           
        }
        public void setCONDICION(CONDICION cond)
        {
            condicion = cond;
        }
        public CONDICION  getCONDICION()
        {
            return condicion;
        }
        public void setCATEGORIA(CATEGORIA cate)
        {
            categoria = cate;
        }
        public CATEGORIA getCATEGORIA()
        {
            return categoria;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public class club 
    {
        private string nombre;
        private int anioFundacion;
        private direccion Direccion;
        private List<equipo> listaEquipo;
        private List<empleado> listaEmpleados;
      
        public void setNombre (string n)
        {
            this.nombre = n;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setFundacion (int f)
        {
              this.anioFundacion = f;
        }
        public int getFundacion()
        {
            return this.anioFundacion;
        }
        public direccion setDireccion(direccion d)
        {
            return this.Direccion = d;

        }
        public direccion getDireccion()
        {
            return this.Direccion;

        }

        public void agregarEquipo (equipo e)
        {
            listaEquipo.Add(e);

        }
        public void removerEquipo(equipo e)
        {
            listaEquipo.Remove(e);
        }
        public void agregarEmpleado(empleado em)
        {
            listaEmpleados.Add(em);

        }
        public void removerEmpleado(empleado em)
        {
            listaEmpleados.Remove(em);
        }


    }


}

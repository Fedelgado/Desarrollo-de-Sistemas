using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    public class equipo
    {
        private categoria Categoria;
        private List<jugador> listaJugadores;
        private entrenador Entranador;


        public categoria setCategoria (categoria c)
        {

            return  Categoria = c;

        }

        public categoria getCategoria()
        {

            return Categoria;

        }

        public entrenador setEntrenador (entrenador e)
        {
            return Entranador = e;
        }
        public entrenador GetEntrenador()
        {
            return Entranador;
        }

        public void AgregarJugador (jugador j)
        {
             listaJugadores.Add(j);

        }
        public void quitarJugador (jugador jj)
        {
            listaJugadores.Remove(jj);

        }


    }
}

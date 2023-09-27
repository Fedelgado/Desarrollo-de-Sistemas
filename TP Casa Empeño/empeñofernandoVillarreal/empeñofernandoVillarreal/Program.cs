using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empeñofernandoVillarreal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            casaEmpeño casa = new casaEmpeño();
            articulo ar = new articulo();
            direccion dire = new direccion();

            ar.setNombre("jabon");
            ar.setprecio(125);
            ar.setCATEGORIA(CATEGORIA.ARTICULO_VARIO);
            ar.setCONDICION(CONDICION.REGULAR);

            dire.setCalle("San juan");
            dire.setAltura(1245);
            dire.setcodigoPostal(910);


            casa.setNombre("Las mil piezas");
            casa.setDireccion(dire);

            Console.WriteLine("busqueda de articulo... " + casa.buscarArticulo(ar.getNombre()));
            
            casa.agregarArticulo(ar);

            
            Console.WriteLine("busqueda de articulo... " + casa.buscarArticulo(ar.getNombre()));

            casa.removerArticulo(ar.getNombre());

            Console.WriteLine("busqueda de articulo... " + casa.buscarArticulo(ar.getNombre()));


            Console.ReadKey();

        }
    }
}

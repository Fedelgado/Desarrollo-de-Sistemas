using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubFernandoVillarreal
{
    internal class Program
    {
        static void Main(string[] args)
        {
           empleado e1 = new empleado ( );
           empleado e2 = new empleado ( );
           empleado e3 = new empleado ( ); 
            jugador j1 = new jugador ( );
            jugador j2 = new jugador();
            jugador j3 = new jugador();
            jugador j4 = new jugador();
            jugador j5 = new jugador();
            jugador j6 = new jugador();
            jugador j7 = new jugador();
            jugador j8 = new jugador();
            jugador j9 = new jugador();
            jugador j10 = new jugador();
            entrenador entre1 = new entrenador();
            entrenador entre2 = new entrenador();
            entrenador entre3 = new entrenador();
            equipo eq1 = new equipo();
            equipo eq2 = new equipo();
            equipo eq3 = new equipo();
            club club1 = new club();



            e1.setNombre("Fernando");
            e2.setNombre("Roberto");
            e3.setNombre("Diego");
            e1.setApellido("Villarreal");
            e2.setApellido("Galati");
            e3.setApellido("Gonzales");
            e1.setFuncion("administrador");
            e2.setFuncion("Supervisor");
            e3.setFuncion("seguridad");


            j1.setNombre("Leonel");
            j2.setNombre("Marino");
            j3.setNombre("Pepe");
            j4.setNombre("tomas");
            j5.setNombre("Pable");
            j6.setNombre("Rodrigo");
            j7.setNombre("Luciano");
            j8.setNombre("Samuel");
            j9.setNombre("Juan");
            j10.setNombre("Cristian");           
            j1.setApellido("Messi");
            j2.setApellido("Bondar");
            j3.setApellido("Vargas");
            j4.setApellido("Trono");
            j5.setApellido("Crespo");
            j6.setApellido("Cardenas");
            j7.setApellido("Ozer");
            j8.setApellido("Lessandro");
            j9.setApellido("Vonichi");
            j10.setApellido("Troca");
            j1.setDorsal(10);
            j2.setDorsal(1);
            j3.setDorsal(8);
            j4.setDorsal(23);
            j5.setDorsal(55);
            j6.setDorsal(88);
            j7.setDorsal(99);
            j8.setDorsal(100);
            j9.setDorsal(3);
            j10.setDorsal(5);



            entre1.setNombre("Rodrigo");
            entre1.setApellido("Migaz");
            entre1.setTactica(tactica.OFENSIVA);
            entre2.setNombre("Pocho");
            entre2.setApellido("Tucun");
            entre2.setTactica(tactica.DEFENSIVA);
            entre3.setNombre("Miguel");
            entre3.setApellido("Mordillo");
            entre3.setTactica(tactica.EQUILIBRADA);



            eq1.setEntrenador(entre1);
            eq1.setCategoria(categoria.PRIMERA);
            eq2.setEntrenador(entre1);
            eq2.setCategoria(categoria.SEGUNDA);
            eq3.setEntrenador(entre1);
            eq3.setCategoria(categoria.TERCERA);



            club1.setNombre("Chicago");
            club1.setFundacion(1890);


            Console.WriteLine("Empleados:");

            Console.WriteLine(e1.presentar());
            Console.WriteLine(e2.presentar());
            Console.WriteLine(e3.presentar());

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Jugadores:");


            Console.WriteLine(j1.presentar());
            Console.WriteLine(j2.presentar());
            Console.WriteLine(j3.presentar());

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Entrenadores:");

            Console.WriteLine(entre1.presentar());
            Console.WriteLine(entre2.presentar());
            Console.WriteLine(entre3.presentar());

            Console.ReadKey();

        }
    }
}

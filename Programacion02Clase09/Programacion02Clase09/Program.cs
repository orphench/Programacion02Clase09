using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona personaUno = new Persona();
            //Los objetos de las clases abastractas no se puede instanciar
            //pero, todas las instancias de las clases que heredan de la abstracta 
            //pueden tomarse como instancias de la clase abstracta

            //Los metodos abastractos solo estan en clases abstractas
            //No tienen implementacion

            List<Persona> ListaPersona = new List<Persona>();
            Alumno alumnoUno = new Alumno("111", 111, "UNO");
            Alumno alumnoDos = new Alumno("222", 222, "DOS");
            AlumnoEgresado alumnoEgresadoUno = new AlumnoEgresado("888", 888, "OCHO", 2016);
            AlumnoEgresado alumnoEgresadoDos = new AlumnoEgresado("999", 999, "NUEVE", 2015);

            ListaPersona.Add(alumnoUno);
            ListaPersona.Add(alumnoDos);
            ListaPersona.Add(alumnoEgresadoUno);
            ListaPersona.Add(alumnoEgresadoDos);

            foreach (Persona item in ListaPersona)
            {
                item.MostrarFecha();
                
            }

            Console.ReadKey();
        }
    }
}
